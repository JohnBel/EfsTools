using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2230)]
    [Attributes(9)]
    public sealed class GsmVmTmBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}