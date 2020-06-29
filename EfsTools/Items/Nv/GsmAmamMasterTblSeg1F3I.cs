using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3078)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg1F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}