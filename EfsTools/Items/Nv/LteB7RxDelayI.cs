using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6542)]
    [Attributes(9)]
    public sealed class LteB7RxDelay
    {
        public short Value { get; set; }
    }
}