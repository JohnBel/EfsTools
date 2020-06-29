using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023783", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DivWcdma1800RxfIciCalDataCar0
    {
        [FieldCount(17)]
        public uint[] Value { get; set; }
    }
}