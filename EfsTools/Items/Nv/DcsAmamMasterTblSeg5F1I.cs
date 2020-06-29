using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2533)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg5F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}