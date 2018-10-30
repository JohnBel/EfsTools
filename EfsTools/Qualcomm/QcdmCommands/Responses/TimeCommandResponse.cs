using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Time)]
    [QcdmMinResponseLength(9)]
    internal class TimeCommandResponse : BaseCommandResponse
    {
        private TimeCommandResponse()
        {
        }

        public long Time { get; private set; }

        public static TimeCommandResponse Parse(byte[] data)
        {
            var result = new TimeCommandResponse();
            result.CheckResponse(data);

            var time = BitConverter.ToInt64(data, 1);
            result.Time = time;
            return result;
        }
    }
}