using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/data/ds_eps_kamgr_pdn.txt", false, 0x8186)]
    [Attributes(9)]
    public sealed class DsEpsKamgrPdnTxt
    {
    }
}