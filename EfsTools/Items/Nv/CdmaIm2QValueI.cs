using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(689)]
    [Attributes(9)]
    public sealed class CdmaIm2QValue
    {
        public byte Value { get; set; }
    }
}