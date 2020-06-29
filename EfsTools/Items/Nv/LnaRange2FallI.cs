using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(377)]
    [Attributes(9)]
    public sealed class LnaRange2Fall
    {
        public sbyte Value { get; set; }
    }
}