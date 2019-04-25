using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Msg)]
    [QcdmMinResponseLength(16)]
    internal class MsgCommandResponse : BaseCommandResponse
    {
        private MsgCommandResponse()
        {
        }

        public string Log { get; private set; }

        public MessageId MessageId { get; private set; }

        public static MsgCommandResponse Parse(byte[] data)
        {
            var result = new MsgCommandResponse();
            result.CheckResponse(data);
            if (data.Length > 16)
            {
                var messageId = (data[14]) + (data[15] << 8);
                result.MessageId = (MessageId)messageId;
            
                result.Log = Encoding.ASCII.GetString(data, 16, data.Length - 16);
            }
            return result;
        }
    }
}