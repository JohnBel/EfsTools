using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(614)]
    [Attributes(9)]
    public sealed class GpsFgTrkOffsetScaler
    {
        public byte Value { get; set; }
    }
}