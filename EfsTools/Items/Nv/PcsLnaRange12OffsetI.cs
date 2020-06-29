using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(389)]
    [Attributes(9)]
    public sealed class PcsLnaRange12Offset
    {
        public short Value { get; set; }
    }
}