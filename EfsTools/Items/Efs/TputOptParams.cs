using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/common/tput_opt_params", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TputOptParams
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public uint Field3 { get; set; }


        public uint Field4 { get; set; }


        public uint Field5 { get; set; }


        public uint Field6 { get; set; }


        public uint Field7 { get; set; }


        public uint Field8 { get; set; }


        public uint Field9 { get; set; }
    }
}