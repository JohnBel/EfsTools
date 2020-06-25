using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(864)]
    [Attributes(9)]
    public sealed class WcdmaImLevel3
    {
        public short Value { get; set; }
    }
}