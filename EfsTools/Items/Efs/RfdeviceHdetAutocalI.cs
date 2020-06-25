using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023764", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RfdeviceHdetAutocal
    {
        public byte HdetAutocalDevice0 { get; set; }


        public byte HdetAutocalDevice1 { get; set; }
    }
}