using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3067)]
    [Attributes(9)]
    public sealed class Gsm850PaEnStart
    {
        public short Value { get; set; }
    }
}