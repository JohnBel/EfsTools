using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1193)]
	[Attributes(13)]
	public class DataServicesMobileIpQcHanddown
    {
		public DataServicesMobileIpQcHanddown()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
