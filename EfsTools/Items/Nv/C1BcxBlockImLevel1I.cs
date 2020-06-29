using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4623)]
    [Attributes(9)]
    public sealed class C1BcxBlockImLevel1
    {
        public byte Value { get; set; }
    }
}