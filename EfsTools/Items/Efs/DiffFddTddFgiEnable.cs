using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/lte/rrc/cap/diff_fdd_tdd_fgi_enable", true, 0xE1FF)]
	[Attributes(9)]
	public class DiffFddTddFgiEnable
	{
		public DiffFddTddFgiEnable()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }
	}
}
