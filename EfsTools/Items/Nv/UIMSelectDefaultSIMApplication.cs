using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(4398)]
	[Attributes(9)]
	public class UimSelectDefaultSimApplication
    {
		public UimSelectDefaultSimApplication()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}