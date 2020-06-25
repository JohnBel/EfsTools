using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020474", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma1900RxfIciCalDataCar1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        public uint[] Value
        {
            get;
        }
    }
}