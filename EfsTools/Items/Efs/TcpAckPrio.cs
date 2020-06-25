using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/data/protocols/tcp_ack_prio", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TcpAckPrio
    {
        public byte Value { get; set; }
    }
}