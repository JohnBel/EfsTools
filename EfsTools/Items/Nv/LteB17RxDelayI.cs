using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6595)]
    [Attributes(9)]
    public sealed class LteB17RxDelay
    {
        public short Value { get; set; }
    }
}