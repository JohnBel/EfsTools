using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6501)]
    [Attributes(9)]
    public sealed class LteB13EncBtf
    {
        public int Value { get; set; }
    }
}