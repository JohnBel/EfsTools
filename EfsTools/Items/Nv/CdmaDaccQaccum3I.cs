using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(675)]
    [Attributes(9)]
    public sealed class CdmaDaccQaccum3
    {
        public byte Value { get; set; }
    }
}