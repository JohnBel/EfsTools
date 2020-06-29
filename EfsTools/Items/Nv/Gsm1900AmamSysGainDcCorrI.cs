using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2757)]
    [Attributes(9)]
    public sealed class Gsm1900AmamSysGainDcCorr
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}