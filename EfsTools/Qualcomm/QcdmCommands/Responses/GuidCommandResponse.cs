using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.GetGuid)]
    [QcdmMinResponseLength(17)]
    internal class GuidCommandResponse : BaseCommandResponse
    {
        private GuidCommandResponse()
        {
        }

        public Guid Guid { get; private set; }

        public static GuidCommandResponse Parse(byte[] data)
        {
            var result = new GuidCommandResponse();
            result.CheckResponse(data);

            var buf = new byte[data.Length - 1];
            Array.Copy(data, 1, buf, 0, buf.Length);
            result.Guid = new Guid(buf);
            return result;
        }
    }
}