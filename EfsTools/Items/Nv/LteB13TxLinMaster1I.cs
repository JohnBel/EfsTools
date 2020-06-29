using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6519)]
    [Attributes(9)]
    public sealed class LteB13TxLinMaster1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}