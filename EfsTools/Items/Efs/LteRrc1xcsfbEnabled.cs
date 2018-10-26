using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/lte/rrc/lte_rrc_1xcsfb_enabled", true, 0xE1FF)]
	[Attributes(9)]
	public class LteRrc1xcsfbEnabled
	{
		public LteRrc1xcsfbEnabled()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
