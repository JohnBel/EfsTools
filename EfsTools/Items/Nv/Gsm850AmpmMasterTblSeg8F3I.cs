using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3133)]
    [Attributes(9)]
    public sealed class Gsm850AmpmMasterTblSeg8F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}