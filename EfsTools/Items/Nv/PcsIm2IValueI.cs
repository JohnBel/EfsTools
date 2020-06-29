using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(688)]
    [Attributes(9)]
    public sealed class PcsIm2IValue
    {
        public byte Value { get; set; }
    }
}