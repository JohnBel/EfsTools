using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5240)]
    [Attributes(9)]
    public sealed class C0Bc10IntelliceiverDetThresh
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public sbyte[] Value
        {
            get;
        }
    }
}