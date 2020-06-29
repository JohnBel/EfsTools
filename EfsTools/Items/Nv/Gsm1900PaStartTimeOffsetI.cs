using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1098)]
    [Attributes(9)]
    public sealed class Gsm1900PaStartTimeOffset
    {
        public sbyte Value { get; set; }
    }
}