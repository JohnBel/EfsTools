using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2152)]
    [Attributes(9)]
    public sealed class Gsm1900Prdi06
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}