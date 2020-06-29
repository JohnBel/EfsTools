using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1307)]
    [Attributes(9)]
    public sealed class CdmaTxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}