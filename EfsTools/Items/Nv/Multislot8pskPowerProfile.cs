using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4158)]
    [Attributes(9)]
    public sealed class Multislot8pskPowerProfile
    {
        public byte Value { get; set; }
    }
}