using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.DiagServ
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.DiagServ, (ushort)QcdmDiagServCommand.GetLogAllocationCount)]
    internal class GetLogAllocationCountRequest : BaseSubSystemCommandRequest
    {
    }
}