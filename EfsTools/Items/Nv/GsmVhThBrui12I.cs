using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2303)]
    [Attributes(9)]
    public sealed class GsmVhThBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}