using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2577)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg1F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}