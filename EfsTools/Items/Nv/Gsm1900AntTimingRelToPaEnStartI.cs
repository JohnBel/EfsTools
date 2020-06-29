using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3069)]
    [Attributes(9)]
    public sealed class Gsm1900AntTimingRelToPaEnStart
    {
        public short Value { get; set; }
    }
}