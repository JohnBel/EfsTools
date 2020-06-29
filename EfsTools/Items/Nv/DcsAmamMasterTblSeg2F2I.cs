using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2562)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg2F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}