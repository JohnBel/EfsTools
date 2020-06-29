using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(388)]
    [Attributes(9)]
    public sealed class PcsLnaRange2Fall
    {
        public sbyte Value { get; set; }
    }
}