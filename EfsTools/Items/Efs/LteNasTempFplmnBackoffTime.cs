using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/nas/lte_nas_temp_fplmn_backoff_time", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteNasTempFplmnBackoffTime
    {
        public uint Value { get; set; }
    }
}