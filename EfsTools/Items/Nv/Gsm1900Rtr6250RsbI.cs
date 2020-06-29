using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3154)]
    [Attributes(9)]
    public sealed class Gsm1900Rtr6250Rsb
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}