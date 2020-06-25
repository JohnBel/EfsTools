using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1897)]
    [Attributes(9)]
    public sealed class Ipv6StateMachineConfiguration
    {
        public ushort InitSolDelay { get; set; }


        public ushort SolInterval { get; set; }


        public ushort ResolInterval { get; set; }


        public ushort MaxSolAttempts { get; set; }


        public ushort MaxResolAttempts { get; set; }


        public ushort PreRaExpResolTime { get; set; }
    }
}