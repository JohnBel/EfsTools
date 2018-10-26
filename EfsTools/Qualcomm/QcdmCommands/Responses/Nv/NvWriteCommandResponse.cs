using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.NvWrite)]
    [QcdmMinResponseLength(3)]
    internal class NvWriteCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private NvWriteCommandResponse()
        {
        }

        public static NvWriteCommandResponse Parse(byte[] data)
        {
            var result = new NvWriteCommandResponse();
            result.CheckResponse(data);
            result.Code = BitConverter.ToUInt16(data, 1);
            return result;
        }

        public ushort Code { get; private set; }
    }
}