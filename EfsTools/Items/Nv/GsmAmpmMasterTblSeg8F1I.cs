using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2592)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg8F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}