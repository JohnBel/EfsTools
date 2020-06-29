using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2623)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg7F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}