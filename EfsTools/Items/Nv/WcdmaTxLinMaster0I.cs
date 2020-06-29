using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(529)]
    [Attributes(9)]
    public sealed class WcdmaTxLinMaster0
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}