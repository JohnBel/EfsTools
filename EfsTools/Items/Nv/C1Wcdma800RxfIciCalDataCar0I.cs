using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7160)]
    [Attributes(9)]
    public sealed class C1Wcdma800RxfIciCalDataCar0
    {
        [FieldCount(17)]
        public uint[] Value { get; set; }
    }
}