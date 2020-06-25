using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021742", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc0IntelliceiverCal
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public ushort[] Value
        {
            get;
        }
    }
}