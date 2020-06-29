using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5441)]
    [Attributes(9)]
    public sealed class C0Bc8LoCal
    {
        [FieldCount(2)]
        public ushort[] Value
        {
            get;
        }
    }
}