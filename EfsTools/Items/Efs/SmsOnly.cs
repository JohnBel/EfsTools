using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/sms_only", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SmsOnly
    {
        public byte Value { get; set; }
    }
}