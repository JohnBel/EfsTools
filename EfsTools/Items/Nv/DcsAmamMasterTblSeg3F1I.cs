using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2531)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg3F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}