using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_octet_aligned_mode_amr_wb", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallOctetAlignedModeAmrWb
    {
        public byte Value { get; set; }
    }
}