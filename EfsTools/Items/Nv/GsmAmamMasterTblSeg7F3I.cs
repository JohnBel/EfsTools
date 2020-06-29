using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3084)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg7F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}