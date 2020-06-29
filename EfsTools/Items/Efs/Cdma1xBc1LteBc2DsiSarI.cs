using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022922", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteBc2DsiSar
    {
        [FieldCount(16)]
        public short[] Value
        {
            get;
        }
    }
}