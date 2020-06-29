using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2647)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmMasterTblSeg7F2
    {
        [FieldCount(32)]
        public uint[] Value { get; set; }
    }
}