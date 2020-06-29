using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3074)]
    [Attributes(9)]
    public sealed class Gsm850PaEnStop
    {
        public short Value { get; set; }
    }
}