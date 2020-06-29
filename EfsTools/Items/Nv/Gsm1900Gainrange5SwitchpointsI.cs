using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3508)]
    [Attributes(9)]
    public sealed class Gsm1900Gainrange5Switchpoints
    {
        [FieldCount(2)]
        public sbyte[] Value { get; set; }
    }
}