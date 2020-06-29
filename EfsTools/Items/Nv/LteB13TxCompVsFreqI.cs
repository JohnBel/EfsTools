using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6526)]
    [Attributes(9)]
    public sealed class LteB13TxCompVsFreq
    {
        [FieldCount(128)]
        public sbyte[] Value { get; set; }
    }
}