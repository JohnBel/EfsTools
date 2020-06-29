using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2567)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg7F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}