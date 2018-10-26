using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(946)]
	[Attributes(41)]
	public class ExpandBandPreference16To32Bits
    {
		public ExpandBandPreference16To32Bits()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("int16")]
		[Description("")]
		public short Field2 { get; set; }

		
	}
}
