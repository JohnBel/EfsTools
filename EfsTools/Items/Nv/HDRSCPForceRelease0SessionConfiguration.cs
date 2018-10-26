using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(4204)]
	[Attributes(9)]
	public class HdrScpForceRelease0SessionConfiguration
    {
		public HdrScpForceRelease0SessionConfiguration()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
