using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(718)]
    [Attributes(9)]
    public sealed class PcsAgcValue4Min
    {
        public sbyte Value { get; set; }
    }
}