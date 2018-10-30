using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.Logmask)]
    internal class LogMaskCommandRequest : BaseCommandRequest, IQcdmCommandRequest
    {
        private readonly byte _mask;

        public LogMaskCommandRequest(byte mask)
        {
            _mask = mask;
        }

        public new byte[] GetData()
        {
            var data = new byte[2];
            data[0] = (byte) Command;
            Array.Copy(new[] {_mask}, 0, data, 1, 1);
            return data;
        }
    }
}