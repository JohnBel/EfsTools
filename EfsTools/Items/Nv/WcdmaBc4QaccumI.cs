using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4168)]
    [Attributes(9)]
    public sealed class WcdmaBc4Qaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}