using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(378)]
    [Attributes(9)]
    public sealed class LnaRange12Offset
    {
        public short Value { get; set; }
    }
}