using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(392)]
    [Attributes(9)]
    public sealed class PcsImLevel1
    {
        public byte Value { get; set; }
    }
}