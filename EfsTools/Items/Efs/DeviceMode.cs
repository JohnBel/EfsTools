using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/device_mode", true, 0xE1FF)]
    [Attributes(9)]
    public class DeviceMode
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}