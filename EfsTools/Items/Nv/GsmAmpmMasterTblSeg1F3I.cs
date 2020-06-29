using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3110)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg1F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}