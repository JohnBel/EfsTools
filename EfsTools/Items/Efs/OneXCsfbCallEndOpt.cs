using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/mmode/sd/1xcsfb_call_end_opt", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class OneXCsfbCallEndOpt
    {
        public byte Value { get; set; }
    }
}