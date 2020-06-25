using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/cp/sap/setpreregstatus", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Setpreregstatus
    {
        public byte Value { get; set; }
    }
}