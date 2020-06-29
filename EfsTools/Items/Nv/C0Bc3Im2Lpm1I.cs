using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3255)]
    [Attributes(9)]
    public sealed class C0Bc3Im2Lpm1
    {
        [FieldCount(3)]
        public byte[] Value
        {
            get;
        }
    }
}