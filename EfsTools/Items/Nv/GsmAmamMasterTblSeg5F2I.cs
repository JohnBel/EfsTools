using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2557)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg5F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}