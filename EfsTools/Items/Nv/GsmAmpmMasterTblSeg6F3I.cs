using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3115)]
    [Attributes(9)]
    public sealed class GsmAmpmMasterTblSeg6F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}