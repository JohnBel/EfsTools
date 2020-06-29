using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3096)]
    [Attributes(9)]
    public sealed class Gsm850AmamMasterTblSeg3F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}