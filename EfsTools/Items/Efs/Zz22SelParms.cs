using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[EfsFile("/nv/item_files/modem/1x/zz2_2_sel_parms", true, 0xE1FF)]
	[Attributes(9)]
	public class Zz22SelParms
	{
		public Zz22SelParms()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field3 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field4 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int32")]
		[Description("")]
		public int Field5 { get; set; }

		
	}
}
