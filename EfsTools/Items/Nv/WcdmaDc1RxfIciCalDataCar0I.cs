using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7199)]
    [Attributes(9)]
    public sealed class WcdmaDc1RxfIciCalDataCar0
    {
        [FieldCount(17)]
        public uint[] Value { get; set; }
    }
}