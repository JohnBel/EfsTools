using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2844)]
    [Attributes(9)]
    public sealed class HdrscpBcmcsEnable
    {
        public uint Value { get; set; }
    }
}