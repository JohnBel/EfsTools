using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(35)]
    [Attributes(41)]
    public sealed class CdmaMobileTerminatedForeignSidRegistrationFlag
    {
        public CdmaMobileTerminatedForeignSidRegistrationFlag()
        {
            Enabled = new sbyte[2];
        }


        public byte Name { get; set; }


        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Enabled { get; set; }
    }
}