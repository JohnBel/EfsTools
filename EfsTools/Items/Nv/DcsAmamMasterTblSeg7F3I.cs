using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3092)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg7F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}