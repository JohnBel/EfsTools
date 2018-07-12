using System;

namespace EfsTools.Qualcomm.QcdmCommands.Attributes
{
    internal class QcdmMinResponseLengthAttribute : Attribute
    {
        public QcdmMinResponseLengthAttribute(int minResponseLength)
        {
            MinResponseLength = minResponseLength;
        }

        public int MinResponseLength { get; private set; }
    }
}
