using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021918", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc5TxApt3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}