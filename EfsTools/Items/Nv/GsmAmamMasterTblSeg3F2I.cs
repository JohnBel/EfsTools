using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2555)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg3F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}