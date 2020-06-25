using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile(" /nv/item_files/modem/nas/lte_nas_ignore_mt_csfb_during_volte_call", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteNasIgnoreMtCsfbDuringVolteCall
    {
        public byte Value { get; set; }
    }
}