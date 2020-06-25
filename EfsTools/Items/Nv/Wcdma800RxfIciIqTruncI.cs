using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6046)]
    [Attributes(9)]
    public sealed class Wcdma800RxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}