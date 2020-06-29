using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(795)]
    [Attributes(9)]
    public sealed class DcsTxBurstRampDownIndex09
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}