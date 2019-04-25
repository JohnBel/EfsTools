using System;
using System.Collections.Generic;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Resourses;
using EfsTools.Utils;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.ExtMsgConfig)]
    [QcdmMinResponseLength(8)]
    internal class ExtMessageConfigCommandResponse : BaseCommandResponse
    {
        private ExtMessageConfigCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public MessageId[] EnabledMessages { get; private set; }

        public static ExtMessageConfigCommandResponse Parse(byte[] data)
        {
            var result = new ExtMessageConfigCommandResponse();
            result.CheckResponse(data);
            var command = data[1];
            var status = data[6];
            result.IsError = status == 0;
            var start = data[2] + (data[3] << 8);
            var end = data[4] + (data[5] << 8);
            var maskLength = end - start + 1;
            if (data.Length < (maskLength + 8))
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
            }

            var enabledMessages = new List<MessageId>();
            for (var i = 0; i < maskLength; ++i)
            {
                var ind = i * 4 + 8;
                if (ind < data.Length)
                {
                    var v = data[ind] + (data[ind + 1] << 8) + (data[ind + 2] << 16) + (data[ind + 3] << 24);
                    if (v != 0)
                    {
                        enabledMessages.Add((MessageId)(i + start));
                    }
                }
            }
            result.EnabledMessages = enabledMessages.ToArray();
            return result;
        }
    }
}