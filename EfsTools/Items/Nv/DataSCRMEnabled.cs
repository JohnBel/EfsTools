using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(429)]
    [Attributes(9)]
    public sealed class DataScRmEnabled
    {
        public byte Value { get; set; }
    }
}