using System;
using System.Linq;
using System.Runtime.CompilerServices;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    internal class BaseSubSystemCommandRequest : BaseCommandRequest, IQcdmCommandRequest
    {
        public BaseSubSystemCommandRequest()
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

        public new byte[] GetData()
        {
            var cmd = BitConverter.GetBytes(SubSystemCommand);
            var data = new byte[] { (byte)Command, (byte)SubSystem, cmd[0], cmd[1] };
            return data;
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
    }
}