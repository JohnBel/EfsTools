using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3142)]
    [Attributes(9)]
    public sealed class GsmAmamArfcnF3
    {
        public ushort Value { get; set; }
    }
}