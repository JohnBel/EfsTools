using System;
using System.Collections.Generic;
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
        private readonly HashSet<LogId> _enabledLogIds;
        private readonly int _scope;
        private readonly Tuple<LogId, LogId> _range;

        public LogConfigCommandRequest(LogConfigOperation operation, int scope, Tuple<LogId, LogId> range, LogId[] enabledLogIds)
        {
            _operation = operation;
            _scope = scope;
            _enabledLogIds = (enabledLogIds == null) ? new HashSet<LogId>() : new HashSet<LogId>(enabledLogIds);
            _range = range;
        }

        public override byte[] GetData()
        {
            byte[] result = null;
            switch (_operation)
            {
                case LogConfigOperation.Disable:
                case LogConfigOperation.RetrieveIdRanges:
                case LogConfigOperation.RetrieveValidMask:
                case LogConfigOperation.GetLMask:
                    result = GetCommandData();
                    break;
                case LogConfigOperation.SetMask:
                    result = GetSetMaskData();
                    break;
                default:
                    result = GetCommandData();
                    break;
            }
            return result;
        }

        private byte[] GetSetMaskData()
        {
            var size = (((int) _range.Item2 - (int) _range.Item1) / 8) + 16;
            var scopeDelta = _scope * 0x1000;
            var begin = ((int)_range.Item1 < scopeDelta) ? _range.Item1 : _range.Item1 - scopeDelta;
            var end = ((int)_range.Item2 < scopeDelta) ? _range.Item2 : _range.Item2 - scopeDelta;
            var data = new byte[size];
            data[0] = (byte)Command;
            data[1] = 0;
            data[2] = 0;
            data[3] = 0;
            data[4] = (byte)((int)_operation & 0xFF);
            data[5] = 0;
            data[6] = 0;
            data[7] = 0;
            data[8] = (byte)(_scope & 0xFF);
            data[9] = 0;
            data[10] = (byte)((int)begin & 0xFF);
            data[11] = (byte)(((int)begin >> 8) & 0xFF);
            data[12] = (byte)((int)end & 0xFF);
            data[13] = (byte)(((int)end >> 8) & 0xFF);
            data[14] = 0;
            data[15] = 0;

            if (_enabledLogIds.Count > 0)
            {
                for (var id = begin; id <= end; ++id)
                {
                    if (_enabledLogIds.Contains((id + scopeDelta)))
                    {
                        BitsUtils.SetBitAsBool(data, 16, (int)id, true);
                    }
                }
            }
            return data;
        }

        private byte[] GetCommandData()
        {
            var data = new byte[8];
            data[0] = (byte)Command;
            data[1] = 0;
            data[2] = 0;
            data[3] = 0;
            data[4] = (byte)((int)_operation & 0xFF);
            data[5] = 0;
            data[6] = 0;
            data[7] = 0;
            return data;
        }
    }
}