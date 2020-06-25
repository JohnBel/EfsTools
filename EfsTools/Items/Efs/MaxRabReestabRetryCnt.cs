using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/3gpp/max_rab_reestab_retry_cnt", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class MaxRabReestabRetryCnt
    {
        public uint Value { get; set; }
    }
}