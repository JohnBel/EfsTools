using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2588)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg4F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}