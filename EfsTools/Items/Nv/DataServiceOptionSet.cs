using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(241)]
    [Attributes(9)]
    public sealed class DataServiceOptionSet
    {
        public byte Value { get; set; }
    }
}