using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3848)]
    [Attributes(9)]
    public sealed class C1RfAntselUmts800
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}