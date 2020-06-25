using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/3gpp2/mpit_enabled", false, 0x81FF)]
    [Attributes(9)]
    public sealed class MpitEnabled
    {
    }
}