using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3103)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg2F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}