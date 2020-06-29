using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2617)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg1F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}