using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/mcfg/mcfg_segload_config", true, 0xE1FF)]
	[Attributes(9)]
	public class McfgSegloadConfig
	{
		public McfgSegloadConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Field2 { get; set; }

		
	}
}
