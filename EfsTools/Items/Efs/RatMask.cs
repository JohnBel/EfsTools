using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/policyman/rat_mask", true, 0xE1FF)]
    [Attributes(9)]
    public class RatMask

    {
        public RatMask()
        {
            Value = new byte[56];
        }

        [ElementsCount(56)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}