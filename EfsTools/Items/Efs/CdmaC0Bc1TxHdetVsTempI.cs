using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024756", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc1TxHdetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] HdetVsTemp
        {
            get;
        }
    }
}