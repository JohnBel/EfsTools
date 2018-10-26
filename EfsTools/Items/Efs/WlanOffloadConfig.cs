using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/data/wlan_config/wlan_offload_config", true, 0xE1FF)]
	[Attributes(9)]
	public class WlanOffloadConfig
    {
		public WlanOffloadConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
