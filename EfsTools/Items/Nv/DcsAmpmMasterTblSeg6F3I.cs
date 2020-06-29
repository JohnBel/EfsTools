using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3123)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg6F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}