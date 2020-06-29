using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6699)]
    [Attributes(9)]
    public sealed class LteB1RxDelay
    {
        public short Value { get; set; }
    }
}