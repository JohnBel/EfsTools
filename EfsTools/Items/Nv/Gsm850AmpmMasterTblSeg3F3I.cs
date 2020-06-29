using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3128)]
    [Attributes(9)]
    public sealed class Gsm850AmpmMasterTblSeg3F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}