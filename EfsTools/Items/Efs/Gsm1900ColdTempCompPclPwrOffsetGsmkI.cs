using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022892", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1900ColdTempCompPclPwrOffsetGsmk
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}