using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Qualcomm.QcdmCommands.Base;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    internal enum ExtMessageConfigOperation
    {
        Disable = 0,
        RetrieveIdRanges = 1,
        RetrieveValidMask = 2,
        SetMask = 4
    }

    [QcdmCommand(QcdmCommand.ExtMsgConfig)]
    internal class ExtMessageConfigCommandRequest : BaseCommandRequest
    {
        private readonly MessageId[] _enabledMessageIds;
        private readonly int _end;
        private readonly ExtMessageConfigOperation _operation;
        private readonly int _start;

        public ExtMessageConfigCommandRequest(ExtMessageConfigOperation operation, int start, int end,
            MessageId[] enabledMessageIds)
        {
            _operation = operation;
            _start = start;
            _end = end;
            _enabledMessageIds = enabledMessageIds;
        }

        public override byte[] GetData()
        {
            byte[] data = null;
            switch (_operation)
            {
                case ExtMessageConfigOperation.Disable:
                case ExtMessageConfigOperation.RetrieveIdRanges:
                    data = GetMaskData();
                    break;
                case ExtMessageConfigOperation.RetrieveValidMask:
                    data = GetRetrieveValidMaskData();
                    break;
                case ExtMessageConfigOperation.SetMask:
                    data = GetSetMaskData();
                    break;
            }

            return data;
        }

        private byte[] GetSetMaskData()
        {
            var messagesLength = _end - _start + 1;
            var data = new byte[messagesLength * 4 + 11];
            data[0] = (byte) Command;
            data[1] = (byte) _operation;
            data[2] = (byte) (_start & 0xFF);
            data[3] = (byte) ((_start >> 8) & 0xFF);
            data[4] = (byte) (_end & 0xFF);
            data[5] = (byte) ((_end >> 8) & 0xFF);
            data[6] = 0;
            data[7] = 0;

            foreach (var enabledMessage in _enabledMessageIds)
            {
                var ind = (int) enabledMessage - _start;
                var index = ind * 4 + 8;
                data[index] = 0xFF;
                data[index + 1] = 0xFF;
                data[index + 2] = 0xFF;
                data[index + 3] = 0xFF;
            }

            return data;
        }

        private byte[] GetMaskData()
        {
            var data = new byte[2];
            data[0] = (byte) Command;
            data[1] = (byte) _operation;
            return data;
        }

        private byte[] GetRetrieveValidMaskData()
        {
            var data = new byte[6];
            data[0] = (byte) Command;
            data[1] = (byte) _operation;
            data[2] = (byte) (_start & 0xFF);
            data[3] = (byte) ((_start >> 8) & 0xFF);
            data[4] = (byte) (_end & 0xFF);
            data[5] = (byte) ((_end >> 8) & 0xFF);
            return data;
        }
    }
}