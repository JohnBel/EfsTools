using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021691", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class T1xThermalStateLimits
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}