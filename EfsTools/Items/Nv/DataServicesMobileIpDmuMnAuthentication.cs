using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(889)]
    [Attributes(41)]
    public sealed class DataServicesMobileIpDmuMnAuthentication
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }


        public sbyte Field3 { get; set; }


        public byte Field4 { get; set; }
    }
}