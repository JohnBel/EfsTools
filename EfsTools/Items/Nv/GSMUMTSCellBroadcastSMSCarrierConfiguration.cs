using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1016)]
	[Attributes(9)]
	public class GsmUmtsCellBroadcastSmsCarrierConfiguration
    {
		public GsmUmtsCellBroadcastSmsCarrierConfiguration()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
