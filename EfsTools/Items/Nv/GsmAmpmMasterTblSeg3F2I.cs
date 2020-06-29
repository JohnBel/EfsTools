using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2619)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg3F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}