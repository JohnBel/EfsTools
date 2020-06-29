using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(495)]
    [Attributes(9)]
    public sealed class MipHandoffOptimizationEnabled
    {
        public byte Value { get; set; }
    }
}