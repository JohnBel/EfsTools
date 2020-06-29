using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4050)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxCalChan
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}