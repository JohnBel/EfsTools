using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2558)]
    [Attributes(9)]
    public sealed class GsmAmamMasterTblSeg6F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}