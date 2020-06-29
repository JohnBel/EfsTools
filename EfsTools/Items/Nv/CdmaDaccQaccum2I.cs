using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(671)]
    [Attributes(9)]
    public sealed class CdmaDaccQaccum2
    {
        public byte Value { get; set; }
    }
}