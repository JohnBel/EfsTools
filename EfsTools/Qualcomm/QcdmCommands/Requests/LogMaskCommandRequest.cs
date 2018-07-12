using EfsTools.Qualcomm.QcdmCommands.Attributes;
using System;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.Logmask)]
    internal class LogMaskCommandRequest : BaseCommandRequest, IQcdmCommandRequest
    {
        public LogMaskCommandRequest(byte mask)
        {
            _mask = mask;
        }

        public new byte[] GetData()
        {
            var data = new byte[2];
            data[0] = (byte)Command;
            Array.Copy(new byte[] {_mask}, 0, data, 1, 1);
            return data;
        }

        private readonly byte _mask;
    }
}