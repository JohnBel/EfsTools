using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025135", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB41xIm3Desense
    {
        [FieldCount(16)]
        public short[] Cdma1xBc15LteBc41xIm3Desense
        {
            get;
        }
    }
}