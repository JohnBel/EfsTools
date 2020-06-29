using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6517)]
    [Attributes(9)]
    public sealed class LteB13TxAgcOffset
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}