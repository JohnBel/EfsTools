using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6570)]
    [Attributes(9)]
    public sealed class LteB7TxLinMaster1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}