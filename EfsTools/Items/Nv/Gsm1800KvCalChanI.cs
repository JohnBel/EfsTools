using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5272)]
    [Attributes(9)]
    public sealed class Gsm1800KvCalChan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}