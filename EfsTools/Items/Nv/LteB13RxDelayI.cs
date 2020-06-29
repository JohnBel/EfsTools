using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6491)]
    [Attributes(9)]
    public sealed class LteB13RxDelay
    {
        public short Value { get; set; }
    }
}