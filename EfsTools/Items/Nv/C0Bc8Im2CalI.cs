using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5585)]
    [Attributes(9)]
    public sealed class C0Bc8Im2Cal
    {
        [FieldCount(7)]
        public byte[] Value
        {
            get;
        }
    }
}