using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/data/dsd/ds_apn_switching", true, 0xE1FF)]
	[Attributes(9)]
	public class DsApnSwitching
	{
		public DsApnSwitching()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
