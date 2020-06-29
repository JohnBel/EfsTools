using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3083)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg6F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}