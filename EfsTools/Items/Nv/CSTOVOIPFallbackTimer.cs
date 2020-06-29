using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6830)]
    [Attributes(9)]
    public sealed class CstoVoipFallbackTimer
    {
        public byte Value { get; set; }
    }
}