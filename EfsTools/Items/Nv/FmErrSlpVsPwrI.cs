using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(125)]
    [Attributes(9)]
    public sealed class FmErrSlpVsPwr
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}