using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024829", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1DoBc15GnssIm3Desense
    {
        [FieldCount(10)]
        public short[] Cdma1xBc1DoBc15Im3Desense
        {
            get;
        }
    }
}