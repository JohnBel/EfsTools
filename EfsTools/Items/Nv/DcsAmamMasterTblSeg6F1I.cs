using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2534)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg6F1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}