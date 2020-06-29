using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6605)]
    [Attributes(9)]
    public sealed class LteB17EncBtf
    {
        public short Value { get; set; }
    }
}