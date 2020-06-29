using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(715)]
    [Attributes(9)]
    public sealed class PcsImLevel3
    {
        public sbyte Value { get; set; }
    }
}