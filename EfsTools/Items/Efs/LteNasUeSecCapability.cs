using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/nas/lte_nas_ue_sec_capability", false, 0x81FF)]
    [Attributes(9)]
    public sealed class LteNasUeSecCapability
    {
    }
}