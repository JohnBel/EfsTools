using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.DiagServ, (ushort) QcdmDiagServCommand.GetDebugMessageDroppedCount)]
    [QcdmMinResponseLength(8)]
    internal class
        GetDebugMessageDroppedCountResponse : Int32BaseSubSystemCommandResponse<GetDebugMessageDroppedCountResponse>
    {
    }
}