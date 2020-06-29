using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6521)]
    [Attributes(9)]
    public sealed class LteB13TxLinMaster3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}