using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5579)]
    [Attributes(9)]
    public sealed class C0Bc2Im2Cal
    {
        [FieldCount(7)]
        public byte[] Value
        {
            get;
        }
    }
}