using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5382)]
    [Attributes(9)]
    public sealed class Gsm1800KvVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}