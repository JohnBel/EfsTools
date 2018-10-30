using System;
using System.Linq;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    internal class BaseSubSystemCommandRequest : BaseCommandRequest, IQcdmCommandRequest
    {
        public BaseSubSystemCommandRequest()
        {
            Initialize();
        }

        public QcdmSubSystem SubSystem { get; private set; } = QcdmSubSystem.Legacy;

        public ushort SubSystemCommand { get; private set; }

        public new byte[] GetData()
        {
            var cmd = BitConverter.GetBytes(SubSystemCommand);
            var data = new[] {(byte) Command, (byte) SubSystem, cmd[0], cmd[1]};
            return data;
        }

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
    }
}