using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1971)]
    [Attributes(9)]
    public sealed class WcdmaTxCalChan
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}