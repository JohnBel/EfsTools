using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.BadParm)]
    [QcdmMinResponseLength(0)]
    internal class BadParamCommandResponse : BaseCommandResponse
    {
        private BadParamCommandResponse()
        {
        }

        public static BadParamCommandResponse Parse(byte[] data)
        {
            var result = new BadParamCommandResponse();
            return result;
        }
    }
}