using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/data/3gpp/call_orig_allowed_before_ps_attach", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CallOrigAllowedBeforePsAttach
    {
        public byte Value { get; set; }
    }
}