using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024777", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc14TxHdetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] HdetVsFreq
        {
            get;
        }
    }
}