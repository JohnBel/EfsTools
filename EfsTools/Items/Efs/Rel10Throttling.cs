using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/rel_10_throttling", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Rel10Throttling
    {
        public byte Value { get; set; }
    }
}