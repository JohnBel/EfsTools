using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2565)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg5F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}