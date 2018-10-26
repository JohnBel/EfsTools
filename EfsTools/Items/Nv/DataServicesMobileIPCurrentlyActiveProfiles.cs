using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(464)]
	[Attributes(13)]
	public class DataServicesMobileIpCurrentlyActiveProfiles
    {
		public DataServicesMobileIpCurrentlyActiveProfiles()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
