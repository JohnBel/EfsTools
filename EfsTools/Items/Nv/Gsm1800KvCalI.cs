using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5068)]
    [Attributes(9)]
    public sealed class Gsm1800KvCal
    {
        public uint Value { get; set; }
    }
}