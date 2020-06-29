using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3065)]
    [Attributes(9)]
    public sealed class DcsPaEnStart
    {
        public short Value { get; set; }
    }
}