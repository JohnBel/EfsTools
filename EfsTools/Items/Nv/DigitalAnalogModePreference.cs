using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(10)]
	[Attributes(41)]
	public class DigitalAnalogModePreference
    {
		public DigitalAnalogModePreference()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Field2 { get; set; }

		
	}
}
