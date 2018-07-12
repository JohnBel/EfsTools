using System;

namespace EfsTools.Qualcomm.QcdmCommands.Attributes
{
    internal class QcdmSubSystemCommandAttribute : Attribute
    {
        public QcdmSubSystemCommandAttribute(QcdmSubSystem subSystem, ushort command)
        {
            SubSystem = subSystem;
            Command = command;
        }

        public QcdmSubSystem SubSystem { get; private set; }
        public ushort Command { get; private set; }
    }
}
