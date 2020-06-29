using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3398)]
    [Attributes(9)]
    public sealed class Gsm1900Precharge
    {
        public ushort Value { get; set; }
    }
}