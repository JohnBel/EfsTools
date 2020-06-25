using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(34)]
    [Attributes(41)]
    public sealed class CdmaMobileTerminatedHomeSidRegistrationFlag
    {
        public CdmaMobileTerminatedHomeSidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Enabled { get; set; }
    }
}