using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022054", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc14TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}