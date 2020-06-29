using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5435)]
    [Attributes(9)]
    public sealed class C0Bc2LoCal
    {
        [FieldCount(2)]
        public ushort[] Value
        {
            get;
        }
    }
}