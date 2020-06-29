using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2156)]
    [Attributes(9)]
    public sealed class Gsm1900Prdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}