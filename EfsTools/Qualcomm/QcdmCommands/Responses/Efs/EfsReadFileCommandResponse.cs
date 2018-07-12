using System;
using System.Dynamic;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.Read)]
    [QcdmMinResponseLength(20)]
    internal class EfsReadFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsReadFileCommandResponse()
        {
        }

        public static EfsReadFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsReadFileCommandResponse();
            result.CheckResponse(data);

            //var file = BitConverter.ToInt32(data, 4);
            //var offset = BitConverter.ToUInt32(data, 8); ;
            var bytesRead = BitConverter.ToInt32(data, 12);
            var error = (QcdmEfsErrors)BitConverter.ToInt32(data, 16);
            result.Error = error;

            if (data.Length < (20 + bytesRead))
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseLength);
            }

            var buf = new byte[bytesRead];
            Array.Copy(data, 20, buf, 0, bytesRead);
            result.Data = buf;
            return result;
        }

        public byte[] Data { get; private set; }
        public QcdmEfsErrors Error { get; private set; }
    }
}