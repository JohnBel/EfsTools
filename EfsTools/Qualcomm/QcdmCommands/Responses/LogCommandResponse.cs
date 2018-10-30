using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Log)]
    [QcdmMinResponseLength(4)]
    internal class LogCommandResponse : BaseCommandResponse
    {
        private LogCommandResponse()
        {
        }

        public string Log { get; private set; }

        public static LogCommandResponse Parse(byte[] data)
        {
            var result = new LogCommandResponse();
            result.CheckResponse(data);

            var entries = data[1];
            var length = BitConverter.ToUInt16(data, 2);
            var l = (ushort) (data.Length - 4);
            length = Math.Min(l, length);
            result.Log = Encoding.ASCII.GetString(data, 4, length);
            return result;
        }
    }
}