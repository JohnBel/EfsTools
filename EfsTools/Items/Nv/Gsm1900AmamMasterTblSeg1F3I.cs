using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3102)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg1F3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}