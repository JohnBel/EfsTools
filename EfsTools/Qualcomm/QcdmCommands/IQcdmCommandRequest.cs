namespace EfsTools.Qualcomm.QcdmCommands
{
    internal interface IQcdmCommandRequest
    {
        byte[] GetData();

        QcdmCommand Command { get; }
    }
}