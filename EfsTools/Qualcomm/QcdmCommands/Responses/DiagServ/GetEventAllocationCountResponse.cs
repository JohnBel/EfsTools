using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.DiagServ, (ushort) QcdmDiagServCommand.GetEventAllocationCount)]
    [QcdmMinResponseLength(8)]
    internal class GetEventAllocationCountResponse : Int32BaseSubSystemCommandResponse<GetEventAllocationCountResponse>
    {
    }
}