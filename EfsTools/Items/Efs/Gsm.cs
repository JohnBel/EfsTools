using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/lte/rrc/irat/gsm", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm
    {
        public uint Value { get; set; }
    }
}