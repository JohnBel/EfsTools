using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2822)]
    [Attributes(9)]
    public sealed class ChgUsbNvdisable
    {
        public byte Value { get; set; }
    }
}