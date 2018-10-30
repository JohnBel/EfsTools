using System.Linq;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    internal class BaseCommandRequest : IQcdmCommandRequest
    {
        public BaseCommandRequest()
        {
            InitializeCommand();
        }

        public QcdmCommand Command { get; private set; } = QcdmCommand.Max;

        public byte[] GetData()
        {
            return new[] {(byte) Command};
        }

        private void InitializeCommand()
        {
            var type = GetType();
            if (Command == QcdmCommand.Max &&
                type.GetCustomAttributes(typeof(QcdmCommandAttribute), true).FirstOrDefault() is QcdmCommandAttribute
                    attribute) Command = attribute.Command;
        }
    }
}