using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/tds_bandpref", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdsBandPref
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}