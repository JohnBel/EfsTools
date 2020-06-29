using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2542)]
    [Attributes(9)]
    public sealed class Gsm850AmamMasterTblSeg6F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}