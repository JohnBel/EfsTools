using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(669)]
    [Attributes(9)]
    public sealed class FmDaccQaccum1
    {
        public byte Value { get; set; }
    }
}