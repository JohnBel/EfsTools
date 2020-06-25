using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/pbm/pbm_nv_ecc_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class PbmNvEccConfig
    {
        public byte Value { get; set; }
    }
}