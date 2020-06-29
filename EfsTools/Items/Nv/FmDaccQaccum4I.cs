using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(681)]
    [Attributes(9)]
    public sealed class FmDaccQaccum4
    {
        public byte Value { get; set; }
    }
}