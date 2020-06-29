using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2540)]
    [Attributes(9)]
    public sealed class Gsm850AmamMasterTblSeg4F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}