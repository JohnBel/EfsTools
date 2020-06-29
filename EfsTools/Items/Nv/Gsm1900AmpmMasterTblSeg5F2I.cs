using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2645)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmMasterTblSeg5F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}