using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2751)]
    [Attributes(9)]
    public sealed class DcsCalpathRsb
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}