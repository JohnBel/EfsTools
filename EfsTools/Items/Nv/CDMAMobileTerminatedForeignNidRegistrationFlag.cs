using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(36)]
	[Attributes(41)]
	public class CdmaMobileTerminatedForeignNidRegistrationFlag
    {
		public CdmaMobileTerminatedForeignNidRegistrationFlag()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field2 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field3 { get; set; }

		
	}
}
