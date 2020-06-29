using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3121)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg4F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}