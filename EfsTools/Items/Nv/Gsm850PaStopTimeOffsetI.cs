using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1141)]
    [Attributes(9)]
    public sealed class Gsm850PaStopTimeOffset
    {
        public sbyte Value { get; set; }
    }
}