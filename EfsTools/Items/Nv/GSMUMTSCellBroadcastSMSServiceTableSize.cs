using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(1015)]
	[Attributes(9)]
	public class GsmUmtsCellBroadcastSmsServiceTableSize
    {
		public GsmUmtsCellBroadcastSmsServiceTableSize()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint16")]
		[Description("")]
		public ushort Value { get; set; }

		
	}
}
