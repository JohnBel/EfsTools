using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(530)]
    [Attributes(9)]
    public sealed class WcdmaTxLinMaster1
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}