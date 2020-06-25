using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4265)]
    [Attributes(9)]
    public sealed class VoipRegistrationMode
    {
        public byte Value { get; set; }
    }
}