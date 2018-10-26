using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/wcdma/rrc/wcdma_rrc_fast_return_to_lte_after_csfb", true, 0xE1FF)]
	[Attributes(9)]
	public class WcdmaRrcFastReturnToLteAfterCsfb
	{
		public WcdmaRrcFastReturnToLteAfterCsfb()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
