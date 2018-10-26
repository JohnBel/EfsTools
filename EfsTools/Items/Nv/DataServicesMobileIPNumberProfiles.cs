using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(463)]
	[Attributes(13)]
	public class DataServicesMobileIpNumberProfiles
    {
		public DataServicesMobileIpNumberProfiles()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
