using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5847)]
    [Attributes(9)]
    public sealed class IWlanMultipleAuthenticationSupported
    {
        public byte Value { get; set; }
    }
}