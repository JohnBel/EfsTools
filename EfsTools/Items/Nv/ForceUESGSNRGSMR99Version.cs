using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1030)]
	[Attributes(9)]
	public class ForceUesgSnrGsmR99Version
    {
		public ForceUesgSnrGsmR99Version()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
