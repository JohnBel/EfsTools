using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/policyman/current_mcc", true, 0xE1FF)]
    [Attributes(9)]
    public class CurrentMcc

    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public UInt32 Value { get; set; }
    }
}