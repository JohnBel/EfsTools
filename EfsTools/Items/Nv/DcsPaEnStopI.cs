using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3072)]
    [Attributes(9)]
    public sealed class DcsPaEnStop
    {
        public short Value { get; set; }
    }
}