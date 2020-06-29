using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2299)]
    [Attributes(9)]
    public sealed class Gsm1900VmThBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}