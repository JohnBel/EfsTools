using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025524", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1900TxEtDelay
    {
        public int Delay { get; set; }
    }
}