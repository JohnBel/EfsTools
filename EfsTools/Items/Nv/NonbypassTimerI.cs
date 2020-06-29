using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(379)]
    [Attributes(9)]
    public sealed class NonbypassTimer
    {
        public byte Value { get; set; }
    }
}