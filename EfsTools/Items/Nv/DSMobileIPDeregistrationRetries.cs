using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(4396)]
	[Attributes(9)]
	public class DsMobileIpDeregistrationRetries
	{
		public DsMobileIpDeregistrationRetries()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Value { get; set; }

		
	}
}
