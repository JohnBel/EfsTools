using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/3gpp2_back_pressure_removal", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ThreeGpp2BackPressureRemoval
    {
        public byte Field1 { get; set; }


        public uint Field2 { get; set; }
    }
}