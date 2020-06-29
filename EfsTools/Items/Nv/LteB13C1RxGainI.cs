using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6537)]
    [Attributes(9)]
    public sealed class LteB13C1RxGain
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}