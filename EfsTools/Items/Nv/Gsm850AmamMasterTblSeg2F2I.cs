using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2570)]
    [Attributes(9)]
    public sealed class Gsm850AmamMasterTblSeg2F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}