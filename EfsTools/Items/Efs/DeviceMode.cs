using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/device_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DeviceMode
    {
        public byte Value { get; set; }
    }
}