using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2600)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg8F1
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}