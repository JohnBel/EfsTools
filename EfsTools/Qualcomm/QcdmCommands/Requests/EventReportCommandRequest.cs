using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.EventReport)]
    internal class EventReportCommandRequest : BaseCommandRequest
    {
        private readonly bool _enable;

        public EventReportCommandRequest(bool enable)
        {
            _enable = enable;
        }

        public override byte[] GetData()
        {
            var data = new byte[2];
            data[0] = (byte) Command;
            data[1] = _enable ? (byte)1 : (byte)0;
            return data;
        }
    }
}