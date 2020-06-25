using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/volte_sr_control", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class VolteSrControl
    {
        public byte Value { get; set; }
    }
}