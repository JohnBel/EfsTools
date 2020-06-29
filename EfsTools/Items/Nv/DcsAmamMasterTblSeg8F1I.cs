using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2536)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg8F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}