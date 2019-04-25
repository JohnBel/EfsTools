using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Time)]
    [QcdmMinResponseLength(9)]
    internal class TimeCommandResponse : BaseCommandResponse
    {
        private TimeCommandResponse()
        {
        }

        public DateTime Time { get; private set; }

        public static TimeCommandResponse Parse(byte[] data)
        {
            var result = new TimeCommandResponse();
            result.CheckResponse(data);

            var time = BitConverter.ToInt64(data, 1);
            result.Time = DateTimeUtils.DateTimeFromQualcommTs(time);
            return result;
        }
    }
}