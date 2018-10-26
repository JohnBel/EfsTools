using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1017)]
	[Attributes(9)]
	public class GsmUmtsCellBroadcastSmsUserPreference
    {
		public GsmUmtsCellBroadcastSmsUserPreference()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
