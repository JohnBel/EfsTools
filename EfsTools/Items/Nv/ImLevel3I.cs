using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(585)]
    [Attributes(9)]
    public sealed class ImLevel3
    {
        public sbyte Value { get; set; }
    }
}