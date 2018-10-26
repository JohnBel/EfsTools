using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(5280)]
	[Attributes(9)]
	public class DisableCmCallType
    {
		public DisableCmCallType()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint64")]
		[Description("")]
		public ulong Value { get; set; }

		
	}
}
