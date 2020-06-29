using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4451)]
    [Attributes(9)]
    public sealed class C1Wcdma1800LnaRangeOffset4
    {
        public short Value { get; set; }
    }
}