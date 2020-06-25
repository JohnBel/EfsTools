using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5700)]
    [Attributes(9)]
    public sealed class Gsm1900TxAgcSettingForPred
    {
        public ushort Value { get; set; }
    }
}