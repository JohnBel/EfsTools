using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(7165)]
	[Attributes(9)]
	public class GnssOemFeatureMask
    {
		public GnssOemFeatureMask()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
