using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(369)]
    [Attributes(9)]
    public sealed class CdmaTxLinMaster2
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }
}