using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4448)]
    [Attributes(9)]
    public sealed class C1Wcdma1800ImLevel4
    {
        public short Value { get; set; }
    }
}