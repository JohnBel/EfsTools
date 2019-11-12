using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.DiagServ, (ushort)QcdmDiagServCommand.GetLogAllocationCount)]
    [QcdmMinResponseLength(8)]
    internal class GetLogAllocationCountResponse : Int32BaseSubSystemCommandResponse<GetLogAllocationCountResponse>
    {

    }
}