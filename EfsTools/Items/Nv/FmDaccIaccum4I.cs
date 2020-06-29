using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(661)]
    [Attributes(9)]
    public sealed class FmDaccIaccum4
    {
        public byte Value { get; set; }
    }
}