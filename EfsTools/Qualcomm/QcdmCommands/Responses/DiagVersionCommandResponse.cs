using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.DiagVersion)]
    [QcdmMinResponseLength(3)]
    internal class DiagVersionCommandResponse : BaseCommandResponse
    {
        private DiagVersionCommandResponse()
        {
        }

        public ushort Version { get; private set; }

        public static DiagVersionCommandResponse Parse(byte[] data)
        {
            var result = new DiagVersionCommandResponse();
            result.CheckResponse(data);

            result.Version = BitConverter.ToUInt16(data, 1);
            return result;
        }
    }
}