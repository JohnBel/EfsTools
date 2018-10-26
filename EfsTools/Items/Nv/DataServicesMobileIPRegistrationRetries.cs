using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(460)]
	[Attributes(9)]
	public class DataServicesMobileIpRegistrationRetries
    {
		public DataServicesMobileIpRegistrationRetries()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
