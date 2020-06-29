using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(450)]
    [Attributes(9)]
    public sealed class DataThrottleEnabled
    {
        public byte Value { get; set; }
    }
}