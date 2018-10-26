using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/data/dynamic_port_cfg", true, 0xE1FF)]
	[Attributes(9)]
	public class DynamicPortCfg
	{
		public DynamicPortCfg()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
