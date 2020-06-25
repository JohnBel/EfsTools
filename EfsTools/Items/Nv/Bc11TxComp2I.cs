using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3861)]
    [Attributes(9)]
    public sealed class Bc11TxComp2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public sbyte[] Value
        {
            get;
        }
    }
}