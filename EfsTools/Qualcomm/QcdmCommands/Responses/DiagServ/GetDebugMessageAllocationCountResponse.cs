using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.DiagServ, (ushort) QcdmDiagServCommand.GetDebugMessageAllocationCount)]
    [QcdmMinResponseLength(8)]
    internal class
        GetDebugMessageAllocationCountResponse : Int32BaseSubSystemCommandResponse<
            GetDebugMessageAllocationCountResponse>
    {
    }
}