using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(619)]
    [Attributes(9)]
    public sealed class CdmaRxfCgIoffset
    {
        public uint Value { get; set; }
    }
}