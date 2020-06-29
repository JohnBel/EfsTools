using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3461)]
    [Attributes(9)]
    public sealed class EnsEnabled
    {
        public byte Value { get; set; }
    }
}