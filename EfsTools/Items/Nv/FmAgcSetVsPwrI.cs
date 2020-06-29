using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(121)]
    [Attributes(9)]
    public sealed class FmAgcSetVsPwr
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}