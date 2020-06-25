using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022572", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB11LnaRangeRiseCar1
    {
        public short Value { get; set; }
    }
}