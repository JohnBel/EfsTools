using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2284)]
    [Attributes(9)]
    public sealed class GsmVmThBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}