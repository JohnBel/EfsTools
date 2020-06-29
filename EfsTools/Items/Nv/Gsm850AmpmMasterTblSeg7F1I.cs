using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2607)]
    [Attributes(9)]
    public sealed class Gsm850AmpmMasterTblSeg7F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}