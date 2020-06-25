using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(260)]
    [Attributes(41)]
    public sealed class OtaPaEnabled
    {
        public byte Nam { get; set; }


        public byte Enabled { get; set; }
    }
}