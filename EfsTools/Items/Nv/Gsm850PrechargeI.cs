using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3396)]
    [Attributes(9)]
    public sealed class Gsm850Precharge
    {
        public ushort Value { get; set; }
    }
}