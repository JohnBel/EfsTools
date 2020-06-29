using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5336)]
    [Attributes(9)]
    public sealed class Gsm900PmeasG1F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}