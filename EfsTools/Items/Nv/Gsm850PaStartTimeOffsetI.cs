using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1140)]
    [Attributes(9)]
    public sealed class Gsm850PaStartTimeOffset
    {
        public sbyte Value { get; set; }
    }
}