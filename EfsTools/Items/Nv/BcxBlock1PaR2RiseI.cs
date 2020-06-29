using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6068)]
    [Attributes(9)]
    public sealed class BcxBlock1PaR2Rise
    {
        public byte Value { get; set; }
    }
}