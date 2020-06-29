using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(717)]
    [Attributes(9)]
    public sealed class PcsAgcValue3Min
    {
        public sbyte Value { get; set; }
    }
}