using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_vt_quality_selector", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallVtQualitySelector
    {
        public byte Value { get; set; }
    }
}