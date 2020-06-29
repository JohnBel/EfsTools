using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/prereg_backoff_timer_virtual_conn", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class PreregBackoffTimerVirtualConn
    {
        public byte Field1 { get; set; }


        public uint Field2 { get; set; }


        public uint Field3 { get; set; }


        public uint Field4 { get; set; }


        public uint Field5 { get; set; }


        public uint Field6 { get; set; }


        public uint Field7 { get; set; }


        public uint Field8 { get; set; }


        public uint Field9 { get; set; }


        public uint Field10 { get; set; }


        public uint Field11 { get; set; }
    }
}