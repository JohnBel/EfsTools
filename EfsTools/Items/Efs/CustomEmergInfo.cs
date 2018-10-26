using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/custom_emerg_info", true, 0xE1FF)]
	[Attributes(9)]
	public class CustomEmergInfo
	{
		public CustomEmergInfo()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint64")]
		[Description("")]
		public ulong Field5 { get; set; }

		
	}
}
