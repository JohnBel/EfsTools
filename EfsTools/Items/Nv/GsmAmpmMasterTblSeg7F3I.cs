using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3116)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg7F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}