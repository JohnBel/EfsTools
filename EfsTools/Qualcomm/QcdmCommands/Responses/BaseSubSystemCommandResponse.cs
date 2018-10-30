using System;
using System.Linq;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    internal class BaseSubSystemCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        public BaseSubSystemCommandResponse()
        {
            Initialize();
        }

        public QcdmSubSystem SubSystem { get; private set; } = QcdmSubSystem.Legacy;

        public ushort SubSystemCommand { get; private set; }

        private void Initialize()
        {
            var type = GetType();
            if (SubSystem == QcdmSubSystem.Legacy &&
                type.GetCustomAttributes(typeof(QcdmSubSystemCommandAttribute), true).FirstOrDefault() is
                    QcdmSubSystemCommandAttribute attribute)
            {
                SubSystem = attribute.SubSystem;
                SubSystemCommand = attribute.Command;
            }
        }

        public override void CheckResponse(byte[] data)
        {
            if (data.Length < MinResponseLength) throw new QcdmManagerException(Strings.QcdmInvalidResponseLength);

            var command = (QcdmCommand) data[0];
            if (command != Command) throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);

            var subSystem = (QcdmSubSystem) data[1];
            if (subSystem != SubSystem) throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);

            var subSystemCommand = BitConverter.ToUInt16(data, 2);
            if (subSystemCommand != SubSystemCommand)
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
        }
    }
}