using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2704)]
    [Attributes(9)]
    public sealed class WcdmaPaCompensateUpWithDvs
    {
        [FieldCount(10)]
        public short[] Value { get; set; }
    }
}