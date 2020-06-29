using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3261)]
    [Attributes(9)]
    public sealed class C0Bc3Im2Lpm2
    {
        [FieldCount(3)]
        public byte[] Value
        {
            get;
        }
    }
}