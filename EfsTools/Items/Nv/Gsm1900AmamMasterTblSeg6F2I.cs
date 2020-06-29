using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2582)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg6F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}