using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2585)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg1F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}