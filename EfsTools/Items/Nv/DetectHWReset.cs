using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4399)]
    [Attributes(9)]
    public sealed class DetectHWReset
    {
        public byte Value { get; set; }
    }
}