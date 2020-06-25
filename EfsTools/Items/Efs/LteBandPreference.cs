using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/lte_bandpref", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteBandPreference : LteBandsConfigBase
    {
    }
}