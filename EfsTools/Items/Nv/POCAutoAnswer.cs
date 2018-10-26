using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(3189)]
	[Attributes(9)]
	public class PocAutoAnswer
    {
		public PocAutoAnswer()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
