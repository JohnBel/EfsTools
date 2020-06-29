using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2618)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg2F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}