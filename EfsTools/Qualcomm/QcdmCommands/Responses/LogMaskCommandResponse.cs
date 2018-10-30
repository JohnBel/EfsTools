using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Logmask)]
    [QcdmMinResponseLength(2)]
    internal class LogMaskCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private LogMaskCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public static LogMaskCommandResponse Parse(byte[] data)
        {
            var result = new LogMaskCommandResponse();
            result.CheckResponse(data);
            var status = data[1];
            result.IsError = status == 0;
            return result;
        }
    }
}