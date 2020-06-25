using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/mmode/msim_standby_esr_support", true, 0xE1FF)]
    [Attributes(25)]
    public sealed class MsimStandbyEsrSupport
    {
        public byte Field1 { get; set; }


        public byte Field2 { get; set; }
    }
}