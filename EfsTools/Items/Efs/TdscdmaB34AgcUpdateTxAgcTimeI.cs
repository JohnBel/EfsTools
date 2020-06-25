using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022629", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB34AgcUpdateTxAgcTime
    {
        public ushort Value { get; set; }
    }
}