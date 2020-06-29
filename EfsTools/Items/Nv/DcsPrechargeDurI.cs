using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(816)]
    [Attributes(9)]
    public sealed class DcsPrechargeDur
    {
        public ushort Value { get; set; }
    }
}