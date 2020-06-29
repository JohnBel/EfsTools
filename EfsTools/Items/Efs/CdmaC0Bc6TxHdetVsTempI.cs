using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024759", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc6TxHdetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] HdetVsTemp
        {
            get;
        }
    }
}