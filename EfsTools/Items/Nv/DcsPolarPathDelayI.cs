using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2771)]
    [Attributes(9)]
    public sealed class DcsPolarPathDelay
    {
        public short Value { get; set; }
    }
}