using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(863)]
    [Attributes(9)]
    public sealed class WcdmaImLevel2
    {
        public short Value { get; set; }
    }
}