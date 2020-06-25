using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/nas/t3245_timer", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class T3245Timer
    {
        public uint Value { get; set; }
    }
}