using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.DiagServ, (ushort) QcdmDiagServCommand.GetLogDroppedCount)]
    [QcdmMinResponseLength(8)]
    internal class GetLogDroppedCountResponse : Int32BaseSubSystemCommandResponse<GetLogDroppedCountResponse>
    {
    }
}