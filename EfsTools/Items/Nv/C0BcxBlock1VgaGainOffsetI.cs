using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6090)]
    [Attributes(9)]
    public sealed class C0BcxBlock1VgaGainOffset
    {
        public short Value { get; set; }
    }
}