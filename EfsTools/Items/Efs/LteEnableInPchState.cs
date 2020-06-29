using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/mmode/lte_enable_in_pch_state", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteEnableInPchState
    {
        public byte Value { get; set; }
    }
}