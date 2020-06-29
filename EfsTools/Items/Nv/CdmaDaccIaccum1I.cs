using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(647)]
    [Attributes(9)]
    public sealed class CdmaDaccIaccum1
    {
        public byte Value { get; set; }
    }
}