using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2637)]
    [Attributes(9)]
    public sealed class Gsm850AmpmMasterTblSeg5F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}