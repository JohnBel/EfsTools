using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3509)]
    [Attributes(9)]
    public sealed class DcsPolarRampProfile
    {
        [FieldCount(60)]
        public ushort[] Value { get; set; }
    }
}