using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(683)]
    [Attributes(9)]
    public sealed class CdmaDaccGainMult
    {
        public byte Value { get; set; }
    }
}