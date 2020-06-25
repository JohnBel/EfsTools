using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022583", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB11RxfIciCalDataCar1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        public uint[] Value
        {
            get;
        }
    }
}