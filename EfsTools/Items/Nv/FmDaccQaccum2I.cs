using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(673)]
    [Attributes(9)]
    public sealed class FmDaccQaccum2
    {
        public byte Value { get; set; }
    }
}