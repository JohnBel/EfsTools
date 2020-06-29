using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(615)]
    [Attributes(9)]
    public sealed class DigitalFgTrkOffsetScaler
    {
        public byte Value { get; set; }
    }
}