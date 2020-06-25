using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/pdp_profiles/embedded_call_prof_nums", false, 0x81FF)]
    [Attributes(9)]
    public sealed class EmbeddedCallProfNums
    {
    }
}