using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4214)]
    [Attributes(9)]
    public sealed class Gsm850PathDelayCompFreqTbl
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}