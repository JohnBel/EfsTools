using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6294)]
    [Attributes(9)]
    public sealed class Gsm850LinearEnvdcCalVal
    {
        public short Value { get; set; }
    }
}