using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5069)]
    [Attributes(9)]
    public sealed class Gsm1900KvCal
    {
        public uint Value { get; set; }
    }
}