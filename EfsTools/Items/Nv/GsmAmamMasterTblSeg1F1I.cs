using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2521)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg1F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}