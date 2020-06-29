using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2282)]
    [Attributes(9)]
    public sealed class Gsm1900VlThBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}