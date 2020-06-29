using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(813)]
    [Attributes(9)]
    public sealed class GsmPrecharge
    {
        public ushort Value { get; set; }
    }
}