using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4261)]
    [Attributes(9)]
    public sealed class CpuBasedFlowControl
    {
        public byte Value { get; set; }
    }
}