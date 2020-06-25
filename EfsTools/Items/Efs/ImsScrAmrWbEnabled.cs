using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(67284)]
    [EfsFile("/nv/item_files/ims/ims_scr_amr_wb_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsScrAmrWbEnabled
    {
        public byte Value { get; set; }
    }
}