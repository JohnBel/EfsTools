using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3741)]
    [Attributes(9)]
    public sealed class Wcdma900PaCompensateDnWithDvs
    {
        [FieldCount(10)]
        [field: Description("")]
        public short[] Value
        {
            get;
        }
    }
}