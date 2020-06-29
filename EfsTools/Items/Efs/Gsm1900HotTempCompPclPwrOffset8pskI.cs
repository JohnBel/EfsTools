using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022891", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1900HotTempCompPclPwrOffset8psk
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}