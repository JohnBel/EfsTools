using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025131", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB5LteIm3Desense
    {
        [FieldCount(16)]
        public short[] Cdma1xBc0LteBc5LteIm3Desense
        {
            get;
        }
    }
}