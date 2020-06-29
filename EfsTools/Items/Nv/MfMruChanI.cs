using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3631)]
    [Attributes(9)]
    public sealed class MfMruChan
    {
        public ushort Value { get; set; }
    }
}