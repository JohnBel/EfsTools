using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2589)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg5F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}