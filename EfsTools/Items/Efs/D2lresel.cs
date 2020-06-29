using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/hdr/cp/ovhd/d2lresel", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class D2lresel
    {
        public byte Value { get; set; }
    }
}