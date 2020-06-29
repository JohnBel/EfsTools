using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3775)]
    [Attributes(9)]
    public sealed class C1Wcdma2100ImLevel2
    {
        public short Value { get; set; }
    }
}