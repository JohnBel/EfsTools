using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(616)]
    [Attributes(9)]
    public sealed class FmFgTrkOffsetScaler
    {
        public byte Value { get; set; }
    }
}