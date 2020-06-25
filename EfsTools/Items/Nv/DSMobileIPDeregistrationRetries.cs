using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4396)]
    [Attributes(9)]
    public sealed class DsMobileIpDeregistrationRetries
    {
        public byte Value { get; set; }
    }
}