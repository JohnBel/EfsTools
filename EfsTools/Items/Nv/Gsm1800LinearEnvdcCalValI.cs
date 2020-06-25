using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6296)]
    [Attributes(9)]
    public sealed class Gsm1800LinearEnvdcCalVal
    {
        public short Value { get; set; }
    }
}