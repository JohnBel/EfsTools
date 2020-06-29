using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3093)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg8F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}