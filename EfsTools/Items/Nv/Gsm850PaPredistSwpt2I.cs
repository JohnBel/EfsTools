using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5366)]
    [Attributes(9)]
    public sealed class Gsm850PaPredistSwpt2
    {
        public ushort Value { get; set; }
    }
}