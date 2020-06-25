using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/nas/exclude_ptmsi_type_field", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ExcludePtmsiTypeField
    {
        public byte Value { get; set; }
    }
}