namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmDiagServCommand : byte
    {
        GetLogDroppedCount = 53,
        GetEventDroppedCount = 55,
        GetDebugMessageDroppedCount = 57,
        GetLogAllocationCount = 58,
        GetEventAllocationCount = 59,
        GetDebugMessageAllocationCount = 60
    }
}