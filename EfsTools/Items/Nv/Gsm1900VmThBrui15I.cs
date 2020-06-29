using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2295)]
    [Attributes(9)]
    public sealed class Gsm1900VmThBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}