using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5895)]
    [Attributes(9)]
    public sealed class MgrfSupported
    {
        public byte Value { get; set; }
    }
}