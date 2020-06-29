using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2755)]
    [Attributes(9)]
    public sealed class Gsm850AmamSysGainDcCorr
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}