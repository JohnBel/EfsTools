using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2128)]
    [Attributes(9)]
    public sealed class DcsPrdi06
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}