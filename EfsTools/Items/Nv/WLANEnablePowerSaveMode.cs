using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3363)]
    [Attributes(9)]
    public sealed class WlanEnablePowerSaveMode
    {
        public byte Value { get; set; }
    }
}