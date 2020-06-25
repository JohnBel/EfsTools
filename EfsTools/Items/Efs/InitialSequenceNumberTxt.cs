using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/eHRPD/initial_sequence_number.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class InitialSequenceNumberTxt
    {
    }
}