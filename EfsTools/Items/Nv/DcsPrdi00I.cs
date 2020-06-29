using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2122)]
    [Attributes(9)]
    public sealed class DcsPrdi00
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}