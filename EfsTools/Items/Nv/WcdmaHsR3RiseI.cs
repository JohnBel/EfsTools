using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2728)]
    [Attributes(9)]
    public sealed class WcdmaHsR3Rise
    {
        public short Value { get; set; }
    }
}