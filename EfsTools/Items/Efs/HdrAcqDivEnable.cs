using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_enable", true, 0xE1FF)]
	[Attributes(9)]
	public class HdrAcqDivEnable
	{
		public HdrAcqDivEnable()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
