using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2593)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg1F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}