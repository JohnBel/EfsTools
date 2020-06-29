using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021968", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc6TxApt2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}