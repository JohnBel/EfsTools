using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(932)]
	[Attributes(9)]
	public class ProcessIncomingCsDataCallAsInternal
    {
		public ProcessIncomingCsDataCallAsInternal()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
