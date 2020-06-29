using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/nas/nas_lai_change_force_lau_for_emergency", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class NasLaiChangeForceLauForEmergency
    {
        public byte Value { get; set; }
    }
}