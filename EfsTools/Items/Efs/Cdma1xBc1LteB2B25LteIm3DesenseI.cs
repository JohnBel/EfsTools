using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025133", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc1LteB2B25LteIm3Desense
    {
        [FieldCount(16)]
        public short[] Value
        {
            get;
        }
    }
}