using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5698)]
    [Attributes(9)]
    public sealed class Gsm900TxAgcSettingForPred
    {
        public ushort Value { get; set; }
    }
}