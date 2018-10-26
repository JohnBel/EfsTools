using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(553)]
	[Attributes(9)]
	public class GsmA5AlgorithmsSupported
    {
		public GsmA5AlgorithmsSupported()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
