using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(855)]
	[Attributes(9)]
	public class RtreConfiguration
    {
		public RtreConfiguration()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
