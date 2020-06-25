using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(67283)]
    [EfsFile("/nv/item_files/ims/ims_scr_amr_nb_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsScrAmrNbEnabled
    {
        public byte Value { get; set; }
    }
}