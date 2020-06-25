using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022557", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB5RxfIciCalDataCar0
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        public uint[] Value
        {
            get;
        }
    }
}