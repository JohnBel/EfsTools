using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025130", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0LteB51xIm3Desense
    {
        [FieldCount(16)]
        public short[] Cdma1xBc0LteBc51xIm3Desense
        {
            get;
        }
    }
}