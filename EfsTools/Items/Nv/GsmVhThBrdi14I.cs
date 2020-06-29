using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2304)]
    [Attributes(9)]
    public sealed class GsmVhThBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}