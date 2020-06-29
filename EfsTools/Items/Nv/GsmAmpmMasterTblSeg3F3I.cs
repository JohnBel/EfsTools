using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3112)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg3F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}