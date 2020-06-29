using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1308)]
    [Attributes(9)]
    public sealed class CdmaRxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}