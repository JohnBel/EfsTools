using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3090)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg5F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}