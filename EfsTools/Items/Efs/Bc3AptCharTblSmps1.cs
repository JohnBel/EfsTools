using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021103", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Bc3AptCharTblSmps1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ushort[] Value
        {
            get;
        }
    }
}