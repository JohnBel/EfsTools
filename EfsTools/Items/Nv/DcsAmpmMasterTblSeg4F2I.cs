using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2628)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg4F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}