using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(946)]
    [Attributes(41)]
    public sealed class ExpandBandPreference16To32Bits
    {
        public byte Nam { get; set; }


        public short Value { get; set; }
    }
}