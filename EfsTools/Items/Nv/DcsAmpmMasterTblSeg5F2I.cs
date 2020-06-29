using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2629)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg5F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}