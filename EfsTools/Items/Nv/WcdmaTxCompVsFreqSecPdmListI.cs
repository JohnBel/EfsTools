using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4969)]
    [Attributes(9)]
    public sealed class WcdmaTxCompVsFreqSecPdmList
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}