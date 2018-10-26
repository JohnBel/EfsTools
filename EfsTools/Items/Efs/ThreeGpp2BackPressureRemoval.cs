using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/data/3gpp2/3gpp2_back_pressure_removal", true, 0xE1FF)]
	[Attributes(9)]
	public class ThreeGpp2BackPressureRemoval
	{
		public ThreeGpp2BackPressureRemoval()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Field2 { get; set; }

		
	}
}
