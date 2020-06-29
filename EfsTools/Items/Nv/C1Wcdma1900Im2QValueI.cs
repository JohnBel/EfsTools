using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3811)]
    [Attributes(9)]
    public sealed class C1Wcdma1900Im2QValue
    {
        public byte Value { get; set; }
    }
}