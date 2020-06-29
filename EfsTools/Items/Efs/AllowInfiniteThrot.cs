using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/data/3gpp/ps/allow_infinite_throt", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AllowInfiniteThrot
    {
        public byte Value { get; set; }
    }
}