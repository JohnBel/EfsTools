using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3141)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmMasterTblSeg8F3
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}