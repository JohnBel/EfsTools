using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(645)]
    [Attributes(9)]
    public sealed class FmDaccIaccum0
    {
        public byte Value { get; set; }
    }
}