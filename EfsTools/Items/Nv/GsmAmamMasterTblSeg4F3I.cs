using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3081)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg4F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}