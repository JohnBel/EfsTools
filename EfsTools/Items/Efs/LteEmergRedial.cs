using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/lte_emerg_redial", true, 0xE1FF)]
    [Attributes(9)]
    public class LteEmergRedial
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field2 { get; set; }
    }
}