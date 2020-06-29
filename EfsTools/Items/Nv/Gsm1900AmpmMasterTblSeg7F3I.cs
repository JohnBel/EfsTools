using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3140)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmMasterTblSeg7F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}