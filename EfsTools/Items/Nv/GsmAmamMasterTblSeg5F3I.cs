using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3082)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg5F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}