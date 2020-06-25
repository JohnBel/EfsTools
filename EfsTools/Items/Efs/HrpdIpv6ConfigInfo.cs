using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/3gpp2/hrpd_ipv6_config_info", false, 0x81FF)]
    [Attributes(9)]
    public sealed class HrpdIpv6ConfigInfo
    {
    }
}