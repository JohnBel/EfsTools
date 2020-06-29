using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3114)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg5F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}