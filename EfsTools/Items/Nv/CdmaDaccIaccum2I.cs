using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(651)]
    [Attributes(9)]
    public sealed class CdmaDaccIaccum2
    {
        public byte Value { get; set; }
    }
}