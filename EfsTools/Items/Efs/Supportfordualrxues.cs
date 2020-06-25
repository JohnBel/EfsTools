using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/supportfordualrxues", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Supportfordualrxues
    {
        public byte Value { get; set; }
    }
}