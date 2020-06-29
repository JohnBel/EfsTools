using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4157)]
    [Attributes(9)]
    public sealed class MultislotGmskPowerProfile
    {
        public byte Value { get; set; }
    }
}