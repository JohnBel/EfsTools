using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2300)]
    [Attributes(9)]
    public sealed class Gsm1900VmThBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}