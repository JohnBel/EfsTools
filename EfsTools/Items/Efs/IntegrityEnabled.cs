using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/tdscdma/rrc/integrity_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class IntegrityEnabled
    {
        public byte Value { get; set; }
    }
}