using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2578)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg2F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}