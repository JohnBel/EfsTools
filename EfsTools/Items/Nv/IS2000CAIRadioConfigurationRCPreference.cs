using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(405)]
	[Attributes(9)]
	public class Is2000CaiRadioConfigurationRcPreference
    {
		public Is2000CaiRadioConfigurationRcPreference()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
