using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/data/3gpp/lteps/attach_profile", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AttachProfile
    {
        public ushort Value { get; set; }
    }
}