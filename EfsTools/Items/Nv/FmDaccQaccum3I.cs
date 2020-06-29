using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(677)]
    [Attributes(9)]
    public sealed class FmDaccQaccum3
    {
        public byte Value { get; set; }
    }
}