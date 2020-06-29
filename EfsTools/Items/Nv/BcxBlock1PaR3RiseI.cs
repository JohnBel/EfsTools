using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6070)]
    [Attributes(9)]
    public sealed class BcxBlock1PaR3Rise
    {
        public byte Value { get; set; }
    }
}