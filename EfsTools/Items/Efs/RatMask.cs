using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/policyman/rat_mask", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RatMask

    {
        public RatMask()
        {
            Value = new byte[56];
        }

        [FieldCount(56)]
        public byte[] Value { get; set; }
    }
}