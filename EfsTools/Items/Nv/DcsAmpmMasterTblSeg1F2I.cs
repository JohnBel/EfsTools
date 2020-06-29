using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2625)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg1F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}