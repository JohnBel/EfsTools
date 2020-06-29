using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1031)]
    [Attributes(9)]
    public sealed class ForceUemsCrGsmR99Version
    {
        public byte Value { get; set; }
    }
}