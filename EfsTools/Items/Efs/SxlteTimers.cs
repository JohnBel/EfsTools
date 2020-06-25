using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/sxlte_timers", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SxlteTimers
    {
        public ushort Field1 { get; set; }


        public ushort Field2 { get; set; }
    }
}