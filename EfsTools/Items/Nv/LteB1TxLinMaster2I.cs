using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6728)]
    [Attributes(9)]
    public sealed class LteB1TxLinMaster2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}