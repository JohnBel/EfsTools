using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.CallManager
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.CallManager, 0)]
    internal class CallManagerStateInfoCommandRequest : BaseSubSystemCommandRequest, IQcdmCommandRequest
    {
    }
}