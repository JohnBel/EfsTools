using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025129", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc0DoBc0HdrIm3Desense
    {
        [FieldCount(16)]
        public short[] Cdma1xBc0DoBcoHdrIm3Desense
        {
            get;
        }
    }
}