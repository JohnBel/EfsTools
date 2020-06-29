using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(606)]
    [Attributes(9)]
    public sealed class DfmLnaFall
    {
        public sbyte Value { get; set; }
    }
}