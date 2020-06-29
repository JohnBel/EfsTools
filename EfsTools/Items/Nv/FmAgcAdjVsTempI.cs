using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(147)]
    [Attributes(9)]
    public sealed class FmAgcAdjVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}