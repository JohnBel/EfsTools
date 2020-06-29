using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(124)]
    [Attributes(9)]
    public sealed class FmExpHdetVsPwr
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}