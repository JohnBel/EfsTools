using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/mmode/get_net_auto_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GetNetAutoMode
    {
        [Required]
        public byte Version { get; set; }


        public ushort Value { get; set; }


        public ushort Reserved { get; set; }
    }
}