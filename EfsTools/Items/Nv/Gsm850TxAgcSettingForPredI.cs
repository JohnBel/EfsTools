using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5697)]
    [Attributes(9)]
    public sealed class Gsm850TxAgcSettingForPred
    {
        public ushort Value { get; set; }
    }
}