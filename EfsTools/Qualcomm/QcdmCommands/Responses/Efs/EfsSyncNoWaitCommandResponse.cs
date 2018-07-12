using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.SyncNoWait)]
    [QcdmMinResponseLength(14)]
    internal class EfsSyncNoWaitCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsSyncNoWaitCommandResponse()
        {
        }

        public static EfsSyncNoWaitCommandResponse Parse(byte[] data)
        {
            var result = new EfsSyncNoWaitCommandResponse();
            result.CheckResponse(data);

            result.Sequence = BitConverter.ToUInt16(data, 4);
            result.Token = BitConverter.ToUInt32(data, 6);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 10);
            result.Error = error;
            return result;
        }

        public ushort Sequence { get; private set; }
        public uint Token { get; private set; }
        public QcdmEfsErrors Error { get; private set; }
    }
}