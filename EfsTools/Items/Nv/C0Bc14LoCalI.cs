using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5447)]
    [Attributes(9)]
    public sealed class C0Bc14LoCal
    {
        [FieldCount(2)]
        public ushort[] Value
        {
            get;
        }
    }
}