using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(382)]
    [Attributes(9)]
    public sealed class ImLevel2
    {
        public byte Value { get; set; }
    }
}