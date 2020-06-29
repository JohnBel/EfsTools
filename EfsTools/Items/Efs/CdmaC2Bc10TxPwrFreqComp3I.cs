using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022024", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxPwrFreqComp3
    {
        [FieldCount(16)]
        public sbyte[] Value
        {
            get;
        }
    }
}