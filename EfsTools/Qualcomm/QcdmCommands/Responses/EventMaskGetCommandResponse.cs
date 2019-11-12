using System;
using System.Collections.Generic;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Resourses;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.EventMaskGet)]
    [QcdmMinResponseLength(10)]
    internal class EventMaskGetCommandResponse : BaseCommandResponse
    {
        private EventMaskGetCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public EventId[] Events { get; private set; }

        public static EventMaskGetCommandResponse Parse(byte[] data)
        {
            var result = new EventMaskGetCommandResponse();
            result.CheckResponse(data);
            var status = data[1];
            result.IsError = status != 0;
            if (!result.IsError)
            {
                if (data.Length < 8)
                {
                    throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
                }

                var count = (data.Length - 8) / 2;
                var pos = 8;
                var events = new EventId[count];
                for (var i = 0; i < count; ++i)
                {
                    events[i] = (EventId)BitConverter.ToUInt16(data, pos);
                    pos += 2;
                }
                result.Events = events;
            }
            return result;
        }
    }
}