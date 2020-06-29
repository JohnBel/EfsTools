using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025128", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Cdma1xBc15LteB12B171x3rdHarmonicDesense
    {
        [FieldCount(16)]
        public short[] Cdma1xBc15LteB12B173rdHarmonicDesense
        {
            get;
        }
    }
}