using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2021)]
    [Attributes(9)]
    public sealed class PaCompensateUpR2
    {
        public short Value { get; set; }
    }
}