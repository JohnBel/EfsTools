using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(5824)]
	[Attributes(9)]
	public class WwanAccessOverWifiPreferred
    {
		public WwanAccessOverWifiPreferred()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
