using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1030)]
    [Attributes(9)]
    public sealed class ForceUesgSnrGsmR99Version
    {
        public byte Value { get; set; }
    }
}