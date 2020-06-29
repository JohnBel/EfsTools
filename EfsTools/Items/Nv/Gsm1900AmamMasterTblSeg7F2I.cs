using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2583)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg7F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}