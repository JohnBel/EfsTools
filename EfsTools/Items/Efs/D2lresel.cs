using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/hdr/cp/ovhd/d2lresel", true, 0xE1FF)]
	[Attributes(9)]
	public class D2lresel
	{
		public D2lresel()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
