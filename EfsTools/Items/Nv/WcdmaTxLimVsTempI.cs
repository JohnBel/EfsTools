using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(539)]
    [Attributes(9)]
    public sealed class WcdmaTxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}