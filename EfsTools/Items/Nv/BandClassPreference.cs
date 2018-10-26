using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(441)]
	[Attributes(41)]
	public class BandClassPreference
    {
		public BandClassPreference()
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
