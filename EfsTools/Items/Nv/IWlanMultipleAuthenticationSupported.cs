using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5847)]
    [Attributes(9)]
    public sealed class IWlanMultipleAuthenticationSupported
    {
        public byte Value { get; set; }
    }
}