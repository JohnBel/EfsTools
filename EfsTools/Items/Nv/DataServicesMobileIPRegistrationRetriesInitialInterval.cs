using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(461)]
	[Attributes(9)]
	public class DataServicesMobileIpRegistrationRetriesInitialInterval
    {
		public DataServicesMobileIpRegistrationRetriesInitialInterval()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
