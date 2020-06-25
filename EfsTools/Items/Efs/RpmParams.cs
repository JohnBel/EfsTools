using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp/rpm_params", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RpmParams
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public byte Field3 { get; set; }


        public byte Field4 { get; set; }


        public byte Field5 { get; set; }


        public byte Field6 { get; set; }


        public byte Field7 { get; set; }


        public byte Field8 { get; set; }


        public byte Field9 { get; set; }


        public byte Field10 { get; set; }
    }
}