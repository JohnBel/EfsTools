using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataRgiListType
    {
        public byte Mod { get; set; }


        public byte PaState { get; set; }


        public byte ValidRgiNum { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] RgiList
        {
            get;
        }
    }
}