using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1220)]
    [Attributes(9)]
    public sealed class Bc6PaR1Rise
    {
        public byte Value { get; set; }
    }
}