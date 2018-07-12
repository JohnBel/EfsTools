using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.DiagVersion)]
    [QcdmMinResponseLength(3)]
    internal class DiagVersionCommandResponse : BaseCommandResponse
    {
        private DiagVersionCommandResponse()
        {
        }

        public static DiagVersionCommandResponse Parse(byte[] data)
        {
            var result = new DiagVersionCommandResponse();
            result.CheckResponse(data);

            result.Version = BitConverter.ToUInt16(data, 1);
            return result;
        }

        public UInt16 Version { get; private set; }
    }
}