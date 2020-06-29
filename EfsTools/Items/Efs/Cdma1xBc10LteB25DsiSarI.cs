using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023050", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc10LteB25DsiSar
    {
        [FieldCount(16)]
        public short[] Value
        {
            get;
        }
    }
}