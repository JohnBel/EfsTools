using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5383)]
    [Attributes(9)]
    public sealed class Gsm1900KvVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}