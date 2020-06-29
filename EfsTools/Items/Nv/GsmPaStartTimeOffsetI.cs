using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(819)]
    [Attributes(9)]
    public sealed class GsmPaStartTimeOffset
    {
        public sbyte Value { get; set; }
    }
}