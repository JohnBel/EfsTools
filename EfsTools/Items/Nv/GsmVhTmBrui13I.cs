using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2248)]
    [Attributes(9)]
    public sealed class GsmVhTmBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}