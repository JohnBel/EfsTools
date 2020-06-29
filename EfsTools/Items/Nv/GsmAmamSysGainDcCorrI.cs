using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2754)]
    [Attributes(9)]
    public sealed class GsmAmamSysGainDcCorr
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}