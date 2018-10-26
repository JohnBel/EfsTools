using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/data/3gpp2/minapnlist_disallow_call", true, 0xE1FF)]
	[Attributes(9)]
	public class MinapnlistDisallowCall
	{
		public MinapnlistDisallowCall()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
