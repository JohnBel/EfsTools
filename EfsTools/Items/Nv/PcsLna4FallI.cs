using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(602)]
    [Attributes(9)]
    public sealed class PcsLna4Fall
    {
        public sbyte Value { get; set; }
    }
}