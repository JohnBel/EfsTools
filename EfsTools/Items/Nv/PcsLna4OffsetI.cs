using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(603)]
    [Attributes(9)]
    public sealed class PcsLna4Offset
    {
        public short Value { get; set; }
    }
}