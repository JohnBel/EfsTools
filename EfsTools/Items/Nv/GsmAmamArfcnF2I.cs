using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2762)]
    [Attributes(9)]
    public sealed class GsmAmamArfcnF2
    {
        public ushort Value { get; set; }
    }
}