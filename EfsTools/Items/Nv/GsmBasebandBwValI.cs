using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2778)]
    [Attributes(9)]
    public sealed class GsmBasebandBwVal
    {
        public byte Value { get; set; }
    }
}