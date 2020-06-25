namespace EfsTools.Qualcomm.QcdmCommands
{
    internal interface IQcdmCommandRequest
    {
        QcdmCommand Command { get; }
        byte[] GetData();
    }
}