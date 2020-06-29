using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
        [EfsFile("/eHRPD/initial_sequence_number.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class InitialSequenceNumberTxt
    {
    }
}