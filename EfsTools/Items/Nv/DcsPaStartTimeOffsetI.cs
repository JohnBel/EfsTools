using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(821)]
    [Attributes(9)]
    public sealed class DcsPaStartTimeOffset
    {
        public sbyte Value { get; set; }
    }
}