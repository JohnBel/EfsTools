using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(122)]
    [Attributes(9)]
    public sealed class FmAgcSetVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}