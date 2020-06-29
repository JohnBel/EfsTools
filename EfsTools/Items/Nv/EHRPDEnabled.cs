using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6248)]
    [Attributes(9)]
    public sealed class EhrpdEnabled
    {
        public byte Value { get; set; }
    }
}