using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5699)]
    [Attributes(9)]
    public sealed class Gsm1800TxAgcSettingForPred
    {
        public ushort Value { get; set; }
    }
}