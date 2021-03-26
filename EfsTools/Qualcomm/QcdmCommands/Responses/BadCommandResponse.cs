using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.BadCmd)]
    [QcdmMinResponseLength(0)]
    internal class BadCommandResponse : BaseCommandResponse
    {
        private BadCommandResponse()
        {
        }

        public static BadCommandResponse Parse(byte[] data)
        {
            var result = new BadCommandResponse();
            return result;
        }
    }
}