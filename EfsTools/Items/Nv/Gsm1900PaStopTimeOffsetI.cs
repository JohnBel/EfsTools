using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1099)]
    [Attributes(9)]
    public sealed class Gsm1900PaStopTimeOffset
    {
        public sbyte Value { get; set; }
    }
}