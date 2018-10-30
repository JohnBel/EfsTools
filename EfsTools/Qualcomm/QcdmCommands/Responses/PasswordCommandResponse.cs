using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Password)]
    [QcdmMinResponseLength(2)]
    internal class PasswordCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private PasswordCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public static PasswordCommandResponse Parse(byte[] data)
        {
            var result = new PasswordCommandResponse();
            result.CheckResponse(data);
            var status = data[1];
            result.IsError = status == 0;
            return result;
        }
    }
}