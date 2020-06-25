using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.DiagServ, (ushort) QcdmDiagServCommand.GetEventDroppedCount)]
    [QcdmMinResponseLength(8)]
    internal class GetEventDroppedCountResponse : Int32BaseSubSystemCommandResponse<GetEventDroppedCountResponse>
    {
    }
}