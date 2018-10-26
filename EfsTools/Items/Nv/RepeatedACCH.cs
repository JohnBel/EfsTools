using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(5107)]
	[Attributes(9)]
	public class RepeatedAcch
    {
		public RepeatedAcch()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
