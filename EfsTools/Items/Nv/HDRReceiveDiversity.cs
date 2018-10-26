using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(818)]
	[Attributes(9)]
	public class HdrReceiveDiversity
    {
		public HdrReceiveDiversity()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("int8")]
		[Description("")]
		public sbyte Value { get; set; }

		
	}
}
