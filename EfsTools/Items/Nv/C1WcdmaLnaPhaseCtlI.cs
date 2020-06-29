using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4957)]
    [Attributes(9)]
    public sealed class C1WcdmaLnaPhaseCtl
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}