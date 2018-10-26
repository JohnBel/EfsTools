using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1918)]
	[Attributes(9)]
	public class AGpsDefaultQosTime
    {
		public AGpsDefaultQosTime()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Value { get; set; }

		
	}
}
