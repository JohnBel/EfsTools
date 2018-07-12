using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Logmask)]
    [QcdmMinResponseLength(2)]
    internal class LogMaskCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private LogMaskCommandResponse()
        {
        }

        public static LogMaskCommandResponse Parse(byte[] data)
        {
            var result = new LogMaskCommandResponse();
            result.CheckResponse(data);
            var status = data[1];
            result.IsError = (status == 0);
            return result;
        }

        public bool IsError { get; private set; }
    }
}