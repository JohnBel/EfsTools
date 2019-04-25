using System;
using System.Collections.Generic;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Qualcomm.QcdmCommands.Requests;
using EfsTools.Resourses;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.LogConfig)]
    [QcdmMinResponseLength(10)]
    internal class LogConfigCommandResponse : BaseCommandResponse
    {
        private LogConfigCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        private LogConfigOperation Operation { get; set; }
        private int Scope { get; set; }

        public LogId[] EnabledLogs { get; private set; }

        public static LogConfigCommandResponse Parse(byte[] data)
        {
            var result = new LogConfigCommandResponse();
            result.CheckResponse(data);
            var status = data[8];
            result.IsError = status != 0;
            result.Operation = (LogConfigOperation) data[4];
            result.Scope = data[12];
            var numBits = data[16] + (data[17] << 8);
            var maskLength = (numBits + 7) / 8;
            if (data.Length < (maskLength + 16))
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
            }

            var enabledLogs = new List<LogId>();
            for (var i = 0; i < numBits; ++i)
            {
                if (BitsUtils.GetBitAsBool(data, 20, i))
                {
                    var v = i + 0x1000;
                    enabledLogs.Add((LogId)v);
                }
            }
            result.EnabledLogs = enabledLogs.ToArray();
            return result;
        }
    }
}