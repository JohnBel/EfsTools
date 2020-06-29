using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6)]
    [Attributes(9)]
    public sealed class MobileCaiRevisionNumber
    {
        public byte Value { get; set; }
    }
}