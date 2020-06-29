using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023756", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC1HdrSpurTable
    {
        [FieldCount(30)]
        public QmslRxSpurTableNvType[] SpurInfo
        {
            get;
        }
    }
}