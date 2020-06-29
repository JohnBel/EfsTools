using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3077)]
    [Attributes(9)]
    public sealed class Gsm1900AntTimingRelToPaEnStop
    {
        public short Value { get; set; }
    }
}