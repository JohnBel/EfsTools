using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2306)]
    [Attributes(9)]
    public sealed class GsmVhThBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}