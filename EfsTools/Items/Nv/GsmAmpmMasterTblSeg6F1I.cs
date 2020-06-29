using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2590)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg6F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}