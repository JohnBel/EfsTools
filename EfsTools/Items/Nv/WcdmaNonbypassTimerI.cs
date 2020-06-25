using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(522)]
    [Attributes(9)]
    public sealed class WcdmaNonbypassTimer
    {
        public byte Value { get; set; }
    }
}