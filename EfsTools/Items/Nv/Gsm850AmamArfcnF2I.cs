using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2764)]
    [Attributes(9)]
    public sealed class Gsm850AmamArfcnF2
    {
        public ushort Value { get; set; }
    }
}