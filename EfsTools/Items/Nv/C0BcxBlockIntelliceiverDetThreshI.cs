using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6149)]
    [Attributes(9)]
    public sealed class C0BcxBlockIntelliceiverDetThresh
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public sbyte[] Value
        {
            get;
        }
    }
}