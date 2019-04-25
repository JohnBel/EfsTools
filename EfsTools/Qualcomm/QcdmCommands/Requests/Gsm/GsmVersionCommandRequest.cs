using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Gsm
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Gsm, 0)]
    internal class GsmVersionCommandRequest : BaseSubSystemCommandRequest
    {
    }
}