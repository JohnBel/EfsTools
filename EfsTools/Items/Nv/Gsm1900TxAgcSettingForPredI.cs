using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5700)]
    [Attributes(9)]
    public sealed class Gsm1900TxAgcSettingForPred
    {
        public ushort Value { get; set; }
    }
}