using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(444)]
    [Attributes(9)]
    public sealed class Gps1CdmaRfDelay
    {
        public ushort Value { get; set; }
    }
}