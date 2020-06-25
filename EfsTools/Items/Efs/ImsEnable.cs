using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(67218)]
    [EfsFile("/nv/item_files/ims/IMS_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsEnable
    {
        public byte Value { get; set; }
    }
}