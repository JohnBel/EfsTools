using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2524)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg4F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}