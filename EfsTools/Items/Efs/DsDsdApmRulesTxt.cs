using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/data/ds_dsd_apm_rules.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class DsDsdApmRulesTxt
    {
    }
}