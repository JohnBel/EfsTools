using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/rrc/cap/disable_cap_ies", true, 0xE1FF)]
    [Attributes(9)]
    public class DisableCapIes
    {
        [ElementsCount(8)]
        [ElementType("int8")]
        public sbyte[] Value { get; set; }
    }
}