using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4458)]
    [Attributes(9)]
    public sealed class C1Wcdma1800NonbypassTimer
    {
        public byte Value { get; set; }
    }
}