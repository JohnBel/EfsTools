using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3118)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg1F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}