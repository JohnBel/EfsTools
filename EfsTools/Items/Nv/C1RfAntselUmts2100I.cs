using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3788)]
    [Attributes(9)]
    public sealed class C1RfAntselUmts2100
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}