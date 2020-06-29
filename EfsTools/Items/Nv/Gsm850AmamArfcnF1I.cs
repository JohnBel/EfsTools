using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2760)]
    [Attributes(9)]
    public sealed class Gsm850AmamArfcnF1
    {
        public ushort Value { get; set; }
    }
}