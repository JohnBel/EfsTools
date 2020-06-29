using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1892)]
    [Attributes(9)]
    public sealed class DiagDebugControl
    {
        public byte Value { get; set; }
    }
}