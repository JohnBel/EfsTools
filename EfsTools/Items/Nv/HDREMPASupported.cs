using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4528)]
    [Attributes(9)]
    public sealed class HdrEmpaSupported
    {
        public byte Value { get; set; }
    }
}