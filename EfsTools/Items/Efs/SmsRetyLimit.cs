using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/sms/sms_rety_limit", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SmsRetyLimit
    {
        public byte Value { get; set; }
    }
}