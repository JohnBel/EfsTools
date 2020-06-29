using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7165)]
    [Attributes(9)]
    public sealed class GnssOemFeatureMask
    {
        public uint Value { get; set; }
    }
}