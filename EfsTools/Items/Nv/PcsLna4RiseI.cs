using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(604)]
    [Attributes(9)]
    public sealed class PcsLna4Rise
    {
        public sbyte Value { get; set; }
    }
}