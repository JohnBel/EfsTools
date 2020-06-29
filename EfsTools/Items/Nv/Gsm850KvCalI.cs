using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5066)]
    [Attributes(9)]
    public sealed class Gsm850KvCal
    {
        public uint Value { get; set; }
    }
}