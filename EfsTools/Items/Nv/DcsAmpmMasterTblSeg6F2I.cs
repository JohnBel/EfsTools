using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2630)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg6F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}