using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/data/3gpp/ps/rel_10_throttling", true, 0xE1FF)]
	[Attributes(9)]
	public class Rel10Throttling
	{
		public Rel10Throttling()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
