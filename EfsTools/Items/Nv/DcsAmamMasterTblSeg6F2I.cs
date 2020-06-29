using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2566)]
    [Attributes(9)]
    public sealed class DcsAmamMasterTblSeg6F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}