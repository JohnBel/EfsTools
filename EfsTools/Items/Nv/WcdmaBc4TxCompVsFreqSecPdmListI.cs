using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4989)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxCompVsFreqSecPdmList
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] Value { get; set; }
    }
}