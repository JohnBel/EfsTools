using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2756)]
    [Attributes(9)]
    public sealed class DcsAmamSysGainDcCorr
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}