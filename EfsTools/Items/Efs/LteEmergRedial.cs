using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(73655)]
    [EfsFile("/nv/item_files/modem/mmode/lte_emerg_redial", true, 0xE1FF)]
    [Attributes(9)]
    public class LteEmergRedial
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RedialOnLte { get; set; }
    }
}