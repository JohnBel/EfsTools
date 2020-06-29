using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2010)]
    [Attributes(9)]
    public sealed class WcdmaTxLinMaster3
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}