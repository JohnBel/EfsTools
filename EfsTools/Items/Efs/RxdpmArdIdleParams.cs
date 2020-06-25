using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/tdscdma/l1/rxdpm_ard_idle_params", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RxdpmArdIdleParams
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public ushort Field3 { get; set; }


        public ushort Field4 { get; set; }


        public ushort Field5 { get; set; }


        public ushort Field6 { get; set; }


        public ushort Field7 { get; set; }


        public ushort Field8 { get; set; }


        public ushort Field9 { get; set; }


        public int Field10 { get; set; }


        public int Field11 { get; set; }


        public byte Field12 { get; set; }


        public byte Field13 { get; set; }


        public ushort Field14 { get; set; }


        public byte Field15 { get; set; }


        public byte Field16 { get; set; }
    }
}