using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/ds/atcop/atcop_cops_auto_mode.txt", false, 0x81FF)]
    [Attributes(9)]
    public sealed class AtcopCopsAutoModeTxt
    {
    }
}