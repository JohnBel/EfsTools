using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(304)]
    [Attributes(13)]
    public sealed class OTKSLFlag
    {
        public byte Value { get; set; }
    }
}