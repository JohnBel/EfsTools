using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020521", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc15PaSmpsAptRangeList
    {
        [FieldCount(4)]
        public byte[] Value
        {
            get;
        }
    }
}