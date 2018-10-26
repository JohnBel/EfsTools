using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/mmode/c2k_switch_2_srlte", true, 0xE1FF)]
	[Attributes(9)]
	public class C2kSwitch2Srlte
	{
		public C2kSwitch2Srlte()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
