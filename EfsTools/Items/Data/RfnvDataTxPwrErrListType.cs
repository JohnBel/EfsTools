using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataTxPwrErrListType
    {
        public byte Mod { get; set; }


        public byte ChannelIndex { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] PwrErrList
        {
            get;
        }
    }
}