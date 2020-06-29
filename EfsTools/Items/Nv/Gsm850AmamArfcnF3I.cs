using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3144)]
    [Attributes(9)]
    public sealed class Gsm850AmamArfcnF3
    {
        public ushort Value { get; set; }
    }
}