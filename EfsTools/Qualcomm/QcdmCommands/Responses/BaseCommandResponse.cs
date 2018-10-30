using System.Linq;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    internal class BaseCommandResponse : IQcdmCommandResponse
    {
        public BaseCommandResponse()
        {
            Initialize();
        }

        public QcdmCommand Command { get; private set; } = QcdmCommand.Max;

        public int MinResponseLength { get; private set; }

        private void Initialize()
        {
            var type = GetType();
            if (Command == QcdmCommand.Max &&
                type.GetCustomAttributes(typeof(QcdmCommandAttribute), true).FirstOrDefault() is QcdmCommandAttribute
                    attribute)
                Command = attribute.Command;

            if (MinResponseLength == 0 &&
                type.GetCustomAttributes(typeof(QcdmMinResponseLengthAttribute), true).FirstOrDefault() is
                    QcdmMinResponseLengthAttribute attribute2)
                MinResponseLength = attribute2.MinResponseLength;
        }

        public virtual void CheckResponse(byte[] data)
        {
            if (data.Length < MinResponseLength) throw new QcdmManagerException(Strings.QcdmInvalidResponseLength);

            var command = (QcdmCommand) data[0];
            if (command != Command) throw new QcdmManagerException(Strings.QcdmInvalidResponseCommand);
        }
    }
}