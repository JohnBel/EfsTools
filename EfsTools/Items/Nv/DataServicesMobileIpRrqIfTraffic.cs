using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(707)]
	[Attributes(9)]
	public class DataServicesMobileIpRrqIfTraffic
    {
		public DataServicesMobileIpRrqIfTraffic()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
