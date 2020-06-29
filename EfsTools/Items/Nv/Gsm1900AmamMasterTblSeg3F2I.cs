using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2579)]
    [Attributes(9)]
    public sealed class Gsm1900AmamMasterTblSeg3F2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}