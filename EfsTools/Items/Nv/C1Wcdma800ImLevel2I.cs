using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3831)]
    [Attributes(9)]
    public sealed class C1Wcdma800ImLevel2
    {
        public short Value { get; set; }
    }
}