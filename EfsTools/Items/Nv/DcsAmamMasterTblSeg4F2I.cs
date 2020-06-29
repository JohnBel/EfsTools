using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2564)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg4F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}