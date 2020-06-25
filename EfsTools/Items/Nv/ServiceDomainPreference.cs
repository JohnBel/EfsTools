using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(850)]
    [Attributes(41)]
    public sealed class ServiceDomainPreference
    {
        public byte Nam { get; set; }


        [Description("2=CS+PS,3=Any")]
        public ushort ServiceDomain { get; set; }
    }
}