using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1050)]
    [Attributes(9)]
    public sealed class C1CdmaImLevel2
    {
        public byte Value { get; set; }
    }
}