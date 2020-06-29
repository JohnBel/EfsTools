using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2621)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg5F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}