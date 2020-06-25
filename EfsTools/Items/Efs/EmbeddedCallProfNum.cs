using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/pdp_profiles/embedded_call_prof_num", false, 0x81FF)]
    [Attributes(9)]
    public sealed class EmbeddedCallProfNum
    {
    }
}