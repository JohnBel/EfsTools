using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(820)]
    [Attributes(9)]
    public sealed class GsmPaStopTimeOffset
    {
        public sbyte Value { get; set; }
    }
}