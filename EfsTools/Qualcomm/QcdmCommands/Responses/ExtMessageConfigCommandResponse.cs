using System;
using System.Collections.Generic;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Qualcomm.QcdmCommands.Requests;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    internal class MessageIdState
    {
        public MessageIdState(MessageId messageId, ushort state1, ushort state2)
        {
            MessageId = messageId;
            State1 = state1;
            State2 = state2;
        }

        public MessageId MessageId
        {
            get;
        }

        public ushort State1
        {
            get;
        }

        public ushort State2
        {
            get;
        }

        public override string ToString()
        {
            return $"MessageId={MessageId}, State1={State1:X4}, State2={State2:X4}";
        }
    }


    [QcdmCommand(QcdmCommand.ExtMsgConfig)]
    [QcdmMinResponseLength(8)]
    internal class ExtMessageConfigCommandResponse : BaseCommandResponse
    {
        private ExtMessageConfigCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public MessageId[] Messages { get; private set; }
        public MessageIdState[] MessageStates { get; private set; }


        public static ExtMessageConfigCommandResponse Parse(byte[] data)
        {
            var result = new ExtMessageConfigCommandResponse();
            result.CheckResponse(data);
            var command = (ExtMessageConfigOperation) data[1];
            switch (command)
            {
                case ExtMessageConfigOperation.Disable:
                case ExtMessageConfigOperation.RetrieveIdRanges:
                    ParseMessages(result, data);
                    break;
                case ExtMessageConfigOperation.RetrieveValidMask:
                    ParseRetrieveValidMask(result, data);
                    break;
                case ExtMessageConfigOperation.SetMask:
                    ParseSetMask(result, data);
                    break;
            }

            return result;
        }

        private static void ParseSetMask(ExtMessageConfigCommandResponse result, byte[] data)
        {
            var status = data[6];
            result.IsError = status == 0;
            var start = data[2] + (data[3] << 8);
            var end = data[4] + (data[5] << 8);
            var maskLength = end - start + 1;
            if (data.Length < maskLength + 8)
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
                        enabledMessages.Add((MessageId) (i + start));
                    }
                }
            }

            result.Messages = enabledMessages.ToArray();
        }

        private static void ParseMessages(ExtMessageConfigCommandResponse result, byte[] data)
        {
            if (data.Length < 8)
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
            }

            var count = (data.Length - 8) / 2;
            var pos = 8;
            var messages = new MessageId[count];
            for (var i = 0; i < count; ++i)
            {
                messages[i] = (MessageId) BitConverter.ToUInt16(data, pos);
                pos += 2;
            }

            result.Messages = messages;
        }

        private static void ParseRetrieveValidMask(ExtMessageConfigCommandResponse result, byte[] data)
        {
            if (data.Length < 8)
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
            }

            var start = data[2] + (data[3] << 8);
            var end = data[4] + (data[5] << 8);

            var count = (data.Length - 8) / 4;
            var pos = 8;
            var messages = new MessageIdState[count];
            for (var i = 0; i < count; ++i)
            {
                var messageId = (MessageId) (start + i);
                var message = new MessageIdState(messageId, BitConverter.ToUInt16(data, pos),
                    BitConverter.ToUInt16(data, pos + 2));
                pos += 4;
                messages[i] = message;
            }

            result.MessageStates = messages;
        }
    }
}