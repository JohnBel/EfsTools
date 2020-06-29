using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1052)]
    [Attributes(9)]
    public sealed class C1CdmaImLevel4
    {
        public byte Value { get; set; }
    }
}