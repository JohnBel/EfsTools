using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3087)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg2F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}