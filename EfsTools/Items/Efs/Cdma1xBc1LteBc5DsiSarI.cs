using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024843", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc5DsiSar
    {
        [FieldCount(16)]
        public short[] Value
        {
            get;
        }
    }
}