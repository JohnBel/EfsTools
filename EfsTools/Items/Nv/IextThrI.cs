using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(366)]
    [Attributes(9)]
    public sealed class IextThr
    {
        public byte Value { get; set; }
    }
}