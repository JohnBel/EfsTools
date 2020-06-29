using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2302)]
    [Attributes(9)]
    public sealed class GsmVhThBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}