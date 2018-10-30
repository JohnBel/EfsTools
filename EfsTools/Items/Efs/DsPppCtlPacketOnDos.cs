using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/ds_ppp_ctl_packet_on_dos", true, 0xE1FF)]
    [Attributes(9)]
    public class DsPppCtlPacketOnDos
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}