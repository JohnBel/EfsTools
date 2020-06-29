using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3107)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg6F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}