using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3828)]
    [Attributes(9)]
    public sealed class C1Wcdma800LnaRangeFall3
    {
        public short Value { get; set; }
    }
}