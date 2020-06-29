using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3120)]
    [Attributes(9)]
    public sealed class DcsAmpmMasterTblSeg3F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}