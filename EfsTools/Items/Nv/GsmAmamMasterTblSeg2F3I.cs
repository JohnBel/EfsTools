using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3079)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg2F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}