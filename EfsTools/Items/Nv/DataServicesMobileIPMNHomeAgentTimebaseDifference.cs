using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items
{
	[Serializable]
	[NvItemId(494)]
	[Attributes(41)]
	public class DataServicesMobileIpMnHomeAgentTimebaseDifference
    {
		public DataServicesMobileIpMnHomeAgentTimebaseDifference()
		{
		}
		
		[ElementsCount(1)]
		[ElementType("uint8")]
		[Description("")]
		public byte Field1 { get; set; }

		
		[ElementsCount(1)]
		[ElementType("uint32")]
		[Description("")]
		public uint Field2 { get; set; }

		
	}
}
