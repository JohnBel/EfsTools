using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2574)]
    [Attributes(9)]
    public sealed class Gsm850AmamMasterTblSeg6F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}