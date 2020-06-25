using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2949)]
    [Attributes(9)]
    public sealed class Wcdma800DchAgcUpdateTxAgcTime
    {
        public short Value { get; set; }
    }
}