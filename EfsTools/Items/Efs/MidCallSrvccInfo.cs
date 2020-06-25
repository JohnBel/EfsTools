using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/mid_call_srvcc_info", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class MidCallSrvccInfo
    {
        [Required]
        public byte Version { get; set; }


        public uint ImsCacheExpiryDuration { get; set; }


        public byte MidCallSupport { get; set; }


        public byte SrvccSyncSupport { get; set; }


        public byte Reserved { get; set; }
    }
}