using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4722)]
    [Attributes(9)]
    public sealed class NasReleaseCompliance
    {
        public byte Value { get; set; }
    }
}