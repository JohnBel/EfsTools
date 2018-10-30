using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/nas_lai_change_force_lau_for_emergency", true, 0xE1FF)]
    [Attributes(9)]
    public class NasLaiChangeForceLauForEmergency
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}