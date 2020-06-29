using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5273)]
    [Attributes(9)]
    public sealed class Gsm1900KvCalChan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}