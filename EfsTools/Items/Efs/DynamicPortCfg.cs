using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/data/dynamic_port_cfg", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DynamicPortCfg
    {
        public byte Value { get; set; }
    }
}