using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3113)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg4F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}