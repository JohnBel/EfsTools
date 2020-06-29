using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3117)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg8F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}