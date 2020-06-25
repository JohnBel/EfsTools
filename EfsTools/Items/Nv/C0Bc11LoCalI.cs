using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5444)]
    [Attributes(9)]
    public sealed class C0Bc11LoCal
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] Value
        {
            get;
        }
    }
}