using System;

namespace EfsTools.Qualcomm.QcdmCommands.Attributes
{
    internal class QcdmCommandAttribute : Attribute
    {
        public QcdmCommandAttribute(QcdmCommand command)
        {
            Command = command;
        }

        public QcdmCommand Command { get; }
    }
}