using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2591)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg7F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}