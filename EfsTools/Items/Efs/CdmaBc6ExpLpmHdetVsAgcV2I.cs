using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020686", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaBc6ExpLpmHdetVsAgcV2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        public ushort[] Value
        {
            get;
        }
    }
}