using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2627)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg3F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}