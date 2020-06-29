using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7151)]
    [Attributes(9)]
    public sealed class C1Wcdma2100RxfIciCalDataCar1
    {
        [FieldCount(17)]
        public uint[] Value { get; set; }
    }
}