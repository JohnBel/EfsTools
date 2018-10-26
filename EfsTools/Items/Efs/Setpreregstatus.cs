using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/hdr/cp/sap/setpreregstatus", true, 0xE1FF)]
	[Attributes(9)]
	public class Setpreregstatus
	{
		public Setpreregstatus()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
