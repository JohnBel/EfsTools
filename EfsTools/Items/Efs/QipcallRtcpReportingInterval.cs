using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_rtcp_reporting_interval", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallRtcpReportingInterval
    {
        public uint Value { get; set; }
    }
}