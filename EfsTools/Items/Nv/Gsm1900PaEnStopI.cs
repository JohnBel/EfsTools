using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3076)]
    [Attributes(9)]
    public sealed class Gsm1900PaEnStop
    {
        public short Value { get; set; }
    }
}