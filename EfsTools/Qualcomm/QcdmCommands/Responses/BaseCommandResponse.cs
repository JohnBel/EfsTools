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

        private void Initialize()
        {
            var type = this.GetType();
            if (_command == QcdmCommand.Max && type.GetCustomAttributes(typeof(QcdmCommandAttribute), true).FirstOrDefault() is QcdmCommandAttribute
                attribute)
            {
                _command = attribute.Command;
            }

            if (_minResponseLength == 0 && type.GetCustomAttributes(typeof(QcdmMinResponseLengthAttribute), true).FirstOrDefault() is
                QcdmMinResponseLengthAttribute attribute2)
            {
                _minResponseLength = attribute2.MinResponseLength;
            }
        }

        private QcdmCommand _command = QcdmCommand.Max;
        private int _minResponseLength;

        public QcdmCommand Command
        {
            get => _command;
        }

        public int MinResponseLength
        {
            get => _minResponseLength;
        }

        public virtual void CheckResponse(byte[] data)
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
        }
    }
}