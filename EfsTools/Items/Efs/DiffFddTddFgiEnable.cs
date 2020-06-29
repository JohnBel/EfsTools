using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/lte/rrc/cap/diff_fdd_tdd_fgi_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DiffFddTddFgiEnable
    {
        public byte Value { get; set; }
    }
}