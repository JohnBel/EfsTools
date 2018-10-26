using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(6907)]
	[Attributes(9)]
	public class UimHwSimConfig
    {
		public UimHwSimConfig()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
