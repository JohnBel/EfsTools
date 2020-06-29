using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3431)]
    [Attributes(9)]
    public sealed class GsmPaTransitionTable
    {
        [FieldCount(48)]
        public ushort[] Value { get; set; }
    }
}