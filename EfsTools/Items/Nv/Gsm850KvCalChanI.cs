using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5270)]
    [Attributes(9)]
    public sealed class Gsm850KvCalChan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}