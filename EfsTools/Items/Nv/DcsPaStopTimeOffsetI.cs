using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(822)]
    [Attributes(9)]
    public sealed class DcsPaStopTimeOffset
    {
        public sbyte Value { get; set; }
    }
}