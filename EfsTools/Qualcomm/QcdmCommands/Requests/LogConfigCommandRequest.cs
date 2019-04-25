using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    internal enum LogConfigOperation
    {
        Disable = 0,
        RetrieveIdRanges = 1, 
        RetrieveValidMask = 2,
        SetMask = 3,
        GetLMask = 4
    }
    
    [QcdmCommand(QcdmCommand.LogConfig)]
    internal class LogConfigCommandRequest : BaseCommandRequest
    {
        private readonly LogConfigOperation _operation;
        private readonly LogId[] _enabledLogIds;
        private readonly int _scope;

        public LogConfigCommandRequest(LogConfigOperation operation, int scope, LogId[] enabledLogIds)
        {
            _operation = operation;
            _scope = scope;
            _enabledLogIds = enabledLogIds;
        }

        public override byte[] GetData()
        {
            var data = new byte[527];
            data[0] = (byte) Command;
            data[1] = 0;
            data[2] = 0;
            data[3] = 0;
            data[4] = (byte)((int)_operation & 0xFF);
            data[5] = 0;
            data[6] = 0;
            data[7] = 0;
            data[8] = (byte)(_scope & 0xFF);
            data[9] = 0;
            data[10] = 0;
            data[11] = 0;
            // length
            data[12] = 0;
            data[13] = 0x10;
            data[14] = 0;
            data[15] = 0;

            foreach (var enableLog in _enabledLogIds)
            {
                var ind = (int)enableLog;
                var offset = ind - 0x1000;
                BitsUtils.SetBitAsBool(data, 16, offset, true);
            }
            return data;
        }
    }
}