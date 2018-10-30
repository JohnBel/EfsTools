using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.CallManager
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.CallManager, 0)]
    [QcdmMinResponseLength(6)]
    internal class CallManagerStateInfoCommandResponse : BaseSubSystemCommandResponse
    {
        private CallManagerStateInfoCommandResponse()
        {
        }

        public ushort CallState { get; private set; }

        public static CallManagerStateInfoCommandResponse Parse(byte[] data)
        {
            var result = new CallManagerStateInfoCommandResponse();
            result.CheckResponse(data);
            result.CallState = BitConverter.ToUInt16(data, 4);
            return result;
        }
    }
}