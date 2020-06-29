using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(446)]
    [Attributes(9)]
    public sealed class CdmaEncBtf
    {
        public uint Value { get; set; }
    }
}