using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/data/3gpp/call_orig_allowed_before_ps_attach", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CallOrigAllowedBeforePsAttach
    {
        public byte Value { get; set; }
    }
}