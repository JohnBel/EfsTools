using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(123)]
    [Attributes(9)]
    public sealed class FmAgcSetVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}