using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5280)]
    [Attributes(9)]
    public sealed class DisableCmCallType
    {
        public ulong Value { get; set; }
    }
}