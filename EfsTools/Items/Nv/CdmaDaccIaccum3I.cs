using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(655)]
    [Attributes(9)]
    public sealed class CdmaDaccIaccum3
    {
        public byte Value { get; set; }
    }
}