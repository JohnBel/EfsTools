using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Max)]
    [QcdmMinResponseLength(2)]
    internal class MaxResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private MaxResponse()
        {
        }

        //public bool IsError { get; private set; }

        public static MaxResponse Parse(byte[] data)
        {
            var result = new MaxResponse();
            result.CheckResponse(data);
            var str = Encoding.ASCII.GetString(data, 2, data.Length - 2);
            return result;
        }
    }
}