using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(381)]
    [Attributes(9)]
    public sealed class ImLevel1
    {
        public byte Value { get; set; }
    }
}