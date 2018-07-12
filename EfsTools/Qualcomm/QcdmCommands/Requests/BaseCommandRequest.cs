using System.Linq;
using System.Runtime.CompilerServices;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    internal class BaseCommandRequest : IQcdmCommandRequest
    {
        public BaseCommandRequest()
        {
            InitializeCommand();
        }

        private void InitializeCommand()
        {
            var type = this.GetType();
            if (_command == QcdmCommand.Max && type.GetCustomAttributes(typeof(QcdmCommandAttribute), true).FirstOrDefault() is QcdmCommandAttribute attribute)
            {
                _command = attribute.Command;
            }
        }

        public byte[] GetData()
        {
            return new byte[] { (byte)Command };
        }

        private QcdmCommand _command = QcdmCommand.Max;

        public QcdmCommand Command
        {
            get => _command;
        }
    }
}