using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/sd/sdssscr_timers", false, 0x81FF)]
    [Attributes(9)]
    public class SdssscrTimers
    {
        public SdssscrTimers()
        {
            Value = new uint[50];
        }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Count { get; set; }

        [ElementsCount(50)]
        [ElementType("uint32")]
        [Description("")]
        public uint[] Value { get; set; }
    }
}