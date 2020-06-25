using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/sms_over_s102", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class SmsOverS102
    {
        public byte Value { get; set; }
    }
}