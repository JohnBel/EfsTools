using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2568)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg8F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}