using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Spc)]
    [QcdmMinResponseLength(2)]
    internal class SpcCommandResponse : BaseCommandResponse
    {
        private SpcCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public static SpcCommandResponse Parse(byte[] data)
        {
            var result = new SpcCommandResponse();
            result.CheckResponse(data);
            var status = data[1];
            result.IsError = status == 0;
            return result;
        }
    }
}