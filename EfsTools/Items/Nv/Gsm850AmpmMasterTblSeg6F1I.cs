using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2606)]
    [Attributes(9)]
    public sealed class Gsm850AmpmMasterTblSeg6F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}