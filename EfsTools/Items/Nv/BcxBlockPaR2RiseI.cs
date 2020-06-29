using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4563)]
    [Attributes(9)]
    public sealed class BcxBlockPaR2Rise
    {
        public byte Value { get; set; }
    }
}