using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(335)]
    [Attributes(9)]
    public sealed class PcsHdetOff
    {
        public byte Value { get; set; }
    }
}