using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
    [Ignore]
    [Serializable]
	[EfsFile("/nv/item_files/data/3gpp2/hrpd_ipv6_config_info", false, 0x81FF)]
	[Attributes(9)]
	public class HrpdIpv6ConfigInfo
	{
		public HrpdIpv6ConfigInfo()
		{
		}
		
	}
}
