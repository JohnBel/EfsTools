using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class ProfileBase
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public byte[] Values
        {
            get;
        }
    }
}