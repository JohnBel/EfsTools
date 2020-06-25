using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6409)]
    [Attributes(9)]
    public sealed class Wcdma1800RxfIciQCoef1415
    {
        public uint Value { get; set; }
    }
}