using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5371)]
    [Attributes(9)]
    public sealed class Gsm1900PaPredistSwpt1
    {
        public ushort Value { get; set; }
    }
}