using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3970)]
    [Attributes(9)]
    public sealed class WcdmaTxPdmLin1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ushort[] Value { get; set; }
    }
}