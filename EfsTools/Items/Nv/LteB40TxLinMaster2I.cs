using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6676)]
    [Attributes(9)]
    public sealed class LteB40TxLinMaster2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}