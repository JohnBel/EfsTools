using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2527)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg7F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}