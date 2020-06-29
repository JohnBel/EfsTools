using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5093)]
    [Attributes(9)]
    public sealed class Gsm1800SmpsPdmTbl
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}