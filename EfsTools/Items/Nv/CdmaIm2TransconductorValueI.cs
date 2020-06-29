using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(837)]
    [Attributes(9)]
    public sealed class CdmaIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}