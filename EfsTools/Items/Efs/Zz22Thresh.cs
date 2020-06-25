using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/1x/zz2_2_thresh", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Zz22Thresh
    {
        public byte Field1 { get; set; }


        public sbyte Field2 { get; set; }


        public short Field3 { get; set; }


        public sbyte Field4 { get; set; }


        public short Field5 { get; set; }


        public byte Field6 { get; set; }
    }
}