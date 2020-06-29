using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020474", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma1900RxfIciCalDataCar1
    {
        [FieldCount(17)]
        public uint[] Value
        {
            get;
        }
    }
}