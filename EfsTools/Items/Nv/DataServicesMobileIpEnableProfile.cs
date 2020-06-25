using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(714)]
    [Attributes(13)]
    public sealed class DataServicesMobileIpEnableProfile
    {
        public DataServicesMobileIpEnableProfile()
        {
            EnableProfs = new byte[6];
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] EnableProfs { get; set; }
    }
}