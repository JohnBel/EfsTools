using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.Logmask)]
    internal class LogMaskCommandRequest : BaseCommandRequest
    {
        private readonly LogId[] _enabledLogIds;

        public LogMaskCommandRequest(LogId[] enabledLogIds)
        {
            _enabledLogIds = enabledLogIds;
        }

        public override byte[] GetData()
        {
            /*var maskLength = (MaxMaskBitsCount + 7) / 8;
            var data = new byte[6 + maskLength];
            data[0] = (byte) Command;
            data[1] = 0;
            data[2] = 0;
            data[3] = 0;
            data[4] = (byte)(MaxMaskBitsCount & 0xFF);
            data[5] = (byte)((MaxMaskBitsCount >> 8) & 0xFF);
            foreach (var enableEvent in _enableEvents)
            {
                BitsUtils.SetBitAsBool(data, 6, (int) enableEvent, true);
            }
            return data;*/
            return null;
        }
    }
}