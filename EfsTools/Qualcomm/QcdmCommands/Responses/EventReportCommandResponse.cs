using System;
using System.Collections.Generic;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.EventReport)]
    [QcdmMinResponseLength(3)]
    internal class EventReportCommandResponse : BaseCommandResponse
    {
        private static readonly TimeSpan DeltaTime = new TimeSpan(0, 0, 10);

        private EventReportCommandResponse()
        {
        }

        public bool IsError { get; private set; }
        public EventReportData[] Events { get; private set; }

        public static EventReportCommandResponse Parse(byte[] data)
        {
            var result = new EventReportCommandResponse();
            result.CheckResponse(data);
            var length = data[1] + (data[2] << 8);
            if (data.Length < 4)
            {
                result.IsError = length != 0;
            }
            else
            {
                result.IsError = length != data.Length - 3;
                if (!result.IsError)
                {
                    var events = new List<EventReportData>();
                    var index = 3;
                    while (index < data.Length)
                    {
                        var eventIdRaw = (data[index] + (data[index + 1] << 8)) & 0xFFF;
                        var eventId = (EventId) eventIdRaw;
                        index += 2;
                        var ts = BitConverter.ToInt64(data, index);
                        var time = DateTimeUtils.DateTimeFromQualcommTs(ts);
                        index += 8;
                        var dataLength = FindEventDataLength(eventId, data, index, time);
                        var evData = new byte[dataLength];
                        Array.Copy(data, index, evData, 0, dataLength);
                        index += dataLength;
                        var eventData = new EventReportData(eventId, time, evData);
                        events.Add(eventData);
                    }

                    result.Events = events.ToArray();
                }
            }

            return result;
        }

        private static int FindEventDataLength(EventId eventId, byte[] data, int startIndex, DateTime lastTime)
        {
            for (var i = startIndex + 2; i < data.Length - 8; ++i) // +2 for eventId
            {
                var ts = BitConverter.ToInt64(data, i);
                if (ts >= 0)
                {
                    var time = DateTimeFromQualcommTs(ts);
                    var delta = time - lastTime;
                    if (delta < DeltaTime && delta > -DeltaTime)
                    {
                        var len = i - 2 - startIndex;
                        return len;
                    }
                }
            }

            var len1 = data.Length - startIndex;
            return len1;
        }

        private static DateTime DateTimeFromQualcommTs(long ts)
        {
            try
            {
                var time = DateTimeUtils.DateTimeFromQualcommTs(ts);
                return time;
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
    }

    internal class EventReportData
    {
        public EventReportData(EventId eventId, DateTime time, byte[] data)
        {
            EventId = eventId;
            Time = time;
            Data = data;
        }

        public EventId EventId
        {
            get;
        }

        public DateTime Time
        {
            get;
        }

        public byte[] Data
        {
            get;
        }
    }
}