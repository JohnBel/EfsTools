using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(928)]
	[Attributes(9)]
	public class PzidHysterisisActivationTimer
    {
		public PzidHysterisisActivationTimer()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
