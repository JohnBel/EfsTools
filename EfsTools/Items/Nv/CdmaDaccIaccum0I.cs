using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(643)]
    [Attributes(9)]
    public sealed class CdmaDaccIaccum0
    {
        public byte Value { get; set; }
    }
}