using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2188)]
    [Attributes(9)]
    public sealed class Gsm1900VmTlBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}