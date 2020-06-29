using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3063)]
    [Attributes(9)]
    public sealed class GsmPaEnStart
    {
        public short Value { get; set; }
    }
}