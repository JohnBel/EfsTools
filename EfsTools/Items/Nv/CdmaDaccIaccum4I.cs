using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(659)]
    [Attributes(9)]
    public sealed class CdmaDaccIaccum4
    {
        public byte Value { get; set; }
    }
}