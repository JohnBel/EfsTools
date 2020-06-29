using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5380)]
    [Attributes(9)]
    public sealed class Gsm850KvVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}