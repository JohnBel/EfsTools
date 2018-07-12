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

        private void Initialize()
        {
            var type = this.GetType();
            if (_subSystem == QcdmSubSystem.Legacy && type.GetCustomAttributes(typeof(QcdmSubSystemCommandAttribute), true).FirstOrDefault() is QcdmSubSystemCommandAttribute attribute)
            {
                _subSystem = attribute.SubSystem;
                _subSystemCommand = attribute.Command;
            }
        }

        private QcdmSubSystem _subSystem = QcdmSubSystem.Legacy;
        private ushort _subSystemCommand = 0;

        public QcdmSubSystem SubSystem
        {
            get => _subSystem;
        }

        public ushort SubSystemCommand
        {
            get => _subSystemCommand;
        }

        public override void CheckResponse(byte[] data)
        {
            if (data.Length < MinResponseLength)
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseLength);
            }

            var command = (QcdmCommand) data[0];
            if (command != Command)
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
            }

            var subSystem = (QcdmSubSystem)data[1];
            if (subSystem != SubSystem)
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
            }

            var subSystemCommand = BitConverter.ToUInt16(data, 2);
            if (subSystemCommand != SubSystemCommand)
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
            }
        }
    }
}