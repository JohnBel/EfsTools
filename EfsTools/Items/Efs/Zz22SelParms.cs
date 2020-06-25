using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/1x/zz2_2_sel_parms", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Zz22SelParms
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public byte Field3 { get; set; }


        public byte Field4 { get; set; }


        public int Field5 { get; set; }
    }
}