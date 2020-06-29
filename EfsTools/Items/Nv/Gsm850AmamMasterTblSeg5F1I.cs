using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2541)]
    [Attributes(9)]
    public sealed class Gsm850AmamMasterTblSeg5F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}