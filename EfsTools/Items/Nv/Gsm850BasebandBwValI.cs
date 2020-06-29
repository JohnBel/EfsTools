using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2780)]
    [Attributes(9)]
    public sealed class Gsm850BasebandBwVal
    {
        public byte Value { get; set; }
    }
}