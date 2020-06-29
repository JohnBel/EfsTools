using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5439)]
    [Attributes(9)]
    public sealed class C0Bc6LoCal
    {
        [FieldCount(2)]
        public ushort[] Value
        {
            get;
        }
    }
}