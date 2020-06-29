using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5346)]
    [Attributes(9)]
    public sealed class Gsm1800PmeasG3F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}